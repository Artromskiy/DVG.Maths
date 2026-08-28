# CPU/GPU maths conformance

Status: coordination baseline `v0.1`.

This document is the authoritative test protocol for proving that supported
DeltaMaths operations retain the same semantics when executed by the CLR and
when lowered by DeltaShader and executed by DeltaRender on Vulkan.

It is not a public runtime contract. It does not add APIs to DeltaMaths,
`DeltaShader.Contract` or DeltaRender. All bundle, case and report types
described below belong to test/tooling projects and may evolve together.

## Goal

For every shader-supported overload in `src/DeltaMaths/Vectors/shader-contract.json`, produce
an auditable result with one of these states:

- CPU and GPU values match under an explicit comparison profile;
- the overload is unsupported by the current compiler or device and has a
  concrete diagnostic/capability reason;
- the values differ and the report identifies the exact case and lane.

There are no silent skips. A supported manifest entry without a generated
case or without a reported GPU disposition is a failed conformance run.

The test answers three different questions separately:

1. **CPU reachability:** does the exact CLR overload exist and execute for a
   valid deterministic input?
2. **Compiler conformance:** does DeltaShader resolve that symbol identity and
   publish valid final SPIR-V plus its resolved `ShaderAbi`?
3. **Execution parity:** does Vulkan readback match the CPU result for the same
   input and comparison profile?

A green result at one layer is not evidence for the next layer.

## Coordination baseline

The work was stopped and checkpointed before this protocol was written.

| Repository | Branch | Checkpoint | State at checkpoint |
|---|---|---|---|
| DeltaMaths | `main` | `ea92fad` | CPU conformance scaffold; 551 supported manifest overloads are reflected and invoked once |
| DeltaShader | `main` | `3aa80b1` | unified shader body translator and context authoring checkpoint; no complete maths artifact bundle |
| DeltaShaderPlayground | `main` | `bd94711` | nested playground checkpoint referenced by DeltaShader |
| DeltaRender | `main` | `53f4bff` | canonical compute artifact import, storage upload, dispatch and readback exist; no generic maths parity runner |

The existing `551/551` CPU result proves manifest coverage and CLR
reachability only. Its single finite result per overload is not yet a
correctness proof and must not be reported as CPU/GPU parity.

## Ownership and dependency direction

```text
DeltaMaths
  src/DeltaMaths/Vectors/shader-contract.json
  deterministic cases + CPU results + comparison profiles
                  |
                  v
DeltaShader
  static C# compute fixtures
  final ShaderArtifact { SPIR-V + ShaderAbi }
                  |
                  v
DeltaRender
  headless Vulkan upload -> dispatch -> readback
  comparison report
```

- **DeltaMaths owns mathematical meaning.** It owns overload identity, input
  domains, CPU evaluation and tolerance selection.
- **DeltaShader owns translation.** It maps real Roslyn symbols, compiles
  static fixtures and publishes the existing final artifact contract.
- **DeltaRender owns execution.** It creates resources from the artifact ABI,
  submits Vulkan work and reads bytes back. It does not compile C# or GLSL and
  does not duplicate Maths mappings.

The dependency remains one-way. DeltaMaths never references DeltaShader or
DeltaRender. No production project references a conformance project.

## One semantic case

Each case names one exact manifest overload and contains only deterministic,
portable data:

```text
CaseId
OperationIdentity
Input values as canonical scalar words
Expected CPU value as canonical scalar words
ComparisonProfile
RequiredCapabilities
```

`OperationIdentity` is the complete identity from `shader-contract.json`, not
a short method name. Overloads must never be matched by CLR name alone.

Canonical words preserve values without culture or JSON-number conversion:

- `bool`, `int`, `uint`, `float`: one 32-bit hexadecimal word per lane;
- `double`: two 32-bit words per lane, low word first;
- vectors: lanes in declared component order;
- matrices: columns in the DeltaMaths column-major order;
- quaternion: `x, y, z, w`;
- structures: fields in the generated shader-layout order.

The case format is test tooling, not a cross-project runtime API. A versioned
JSON bundle is preferred initially because failures must be inspectable in CI.
Large generated data may move to a binary payload later while retaining a
small JSON index.

Illustrative shape:

```json
{
  "schemaVersion": 1,
  "mathsCheckpoint": "ea92fad",
  "shaderContract": "src/DeltaMaths/Vectors/shader-contract.json",
  "cases": [
    {
      "id": "float3.dot.nominal-0",
      "operation": "Delta.Maths.float3.Dot(float3,float3)",
      "inputs": [
        { "type": "float3", "words": ["3f800000", "40000000", "40400000"] },
        { "type": "float3", "words": ["40800000", "40a00000", "40c00000"] }
      ],
      "expected": { "type": "float", "words": ["42000000"] },
      "comparison": "FloatBasic",
      "capabilities": []
    }
  ]
}
```

The concrete identity string must be copied from the manifest; the example is
descriptive and is not a replacement for generator output.

## Case corpus

Every supported overload receives at least a nominal case. Additional cases
are selected by operation family:

- zeros and signed zeros where the sign is meaningful;
- positive and negative ordinary values;
- values immediately around discontinuities and clamp/step boundaries;
- small and large finite magnitudes that remain inside the operation domain;
- non-unit vectors, non-orthogonal matrices and non-normalized quaternions;
- deterministic pseudo-random finite values from a recorded seed;
- alias-sensitive and out-parameter cases where the public operation permits
  them.

Domain-invalid inputs are not used merely to increase counts. NaN, infinity,
subnormal and singular cases are separate named profiles because Vulkan
devices and GLSL operations may legally differ in their handling. Excluding
such a category from `v0.1` is allowed only as an explicit reported
disposition, never as a silent omission.

## Same algorithm on both paths

The shader fixture is a static C# method using the real DeltaMaths symbol. The
CPU oracle calls the real CLR overload. The generated GPU entry point applies
that same operation to one case selected by `GlobalInvocationId.X`.

```csharp
internal static float Evaluate(float3 left, float3 right)
{
    return float3.Dot(left, right);
}
```

The CPU path calls `Evaluate`. The compute fixture calls the same static helper
from a statically compiled `[ComputeShader]` entry point. DeltaShader lowers
the helper call graph; the CLR helper is never executed by the GPU.

When a generated helper cannot be shared literally because of an `out`
parameter or a shader storage restriction, both wrappers must contain one call
to the same DeltaMaths overload and only mechanical input/output adaptation.
The report records that adapter kind.

No reflection, delegate, runtime lambda or dynamic shader compilation occurs
inside the GPU hot path. Reflection may be used by the CPU tooling to verify
manifest coverage, but it is not the semantic implementation being compared.

## Shader fixture and artifact bundle

DeltaShader generates static compute fixtures from the Maths case bundle.
Fixtures use a fixed convention:

```text
local size       64, 1, 1
set 0 binding 0  first input, read-only storage buffer
set 0 binding 1  second input when present, read-only storage buffer
...              additional inputs in parameter order
last binding     output, read-write storage buffer
push constant    uint Count
```

Each published item contains:

- the case/operation identity;
- a final `Delta.Shader.Contract.IShaderArtifact` representation;
- the exact resolved `ShaderAbi`;
- the case IDs covered by that artifact;
- optional GLSL and SPIR-V disassembly sidecars for diagnostics only.

DeltaRender consumes only final SPIR-V plus `ShaderAbi`. It does not consume
Roslyn symbols or GLSL and it never invents offsets, strides or descriptor
bindings. Optional sidecars are for humans and compiler tests.

Input buffers use the types declared by the generated fixture so the run also
exercises std430 layout. The output buffer uses a canonical word encoding when
the native result cannot be read back unambiguously (notably booleans). The
artifact ABI remains the sole source of physical offsets, alignment, array
stride and matrix stride.

## Vulkan execution

The parity runner is headless and compute-only. It must not open a window,
present, poll input or depend on the render graph/UI path.

For each artifact:

1. validate the artifact stage, entry point, capabilities and resource ABI;
2. allocate storage buffers using ABI sizes and strides;
3. pack the exact case inputs;
4. upload all inputs and initialize output deterministically;
5. dispatch `ceil(caseCount / localSizeX)` workgroups;
6. wait through the existing renderer-owned synchronization path;
7. read the output buffer once;
8. compare each result and emit one disposition per case.

Buffer and pipeline lifetime stay inside DeltaRender. The test must use
`IComputeDevice.CreateComputePipeline(IShaderArtifact)` rather than a second
Render-owned shader metadata model. Existing raw SPIR-V overloads are not the
normal parity path.

## Comparison profiles

Integer, fixed-point and boolean results use exact canonical words. Floating
point is lane-wise and uses an explicit named profile:

```text
pass = exact bits
    or absolute error <= AbsoluteTolerance
    or relative error <= RelativeTolerance * max(abs(cpu), abs(gpu))
    or ULP distance <= MaxUlps
```

Initial profiles:

| Profile | Intended operations | Rule |
|---|---|---|
| `Exact` | integer, boolean, bitwise, fixed-point | identical canonical words |
| `FloatDiscrete` | comparisons, floor/ceil/trunc, exact constants | identical classification and normally identical bits |
| `FloatBasic` | add/multiply, dot, min/max/clamp | small reviewed ULP bound |
| `FloatTranscendental` | sin/cos/tan, exp/log, sqrt/inverse sqrt | reviewed absolute + relative + ULP bounds |
| `QuaternionEquivalent` | operations whose result may use `q` or `-q` | compare both signs, then apply floating profile |

Tolerance numbers belong to generated case metadata and are reviewed per
operation family. They must not be silently widened after a failure.

Special values:

- NaN matches NaN by classification; payload equality is not required unless
  the case explicitly requests exact bits;
- infinity requires the same sign;
- positive and negative zero are equal for ordinary numeric profiles and
  distinct for sign-sensitive cases;
- subnormal/flush-to-zero behavior is reported under a dedicated profile;
- `double` cases require the Vulkan float64 capability and otherwise report a
  capability exclusion.

## Report

The machine-readable report and concise text summary contain:

```text
Maths, Shader and Render checkpoints
GPU/device/driver and Vulkan capabilities
manifest supported count
CPU case count
compiled artifact count
executed GPU case count
passed, mismatched, compiler-blocked and capability-excluded counts
```

Every mismatch contains:

```text
case id
operation identity
input words
lane/field
CPU word and decoded value
GPU word and decoded value
absolute error
relative error
ULP distance
comparison profile
artifact path
```

Compiler and capability exclusions include their exact diagnostic or missing
capability. A skipped native test is not a pass.

## Delivery order

### Stage 1 — deterministic vertical slice

- scalar and `float2/float3/float4` unary/binary operations;
- at least `abs`, `min`, `max`, `clamp`, `sqrt`, `sin`, `dot`, `cross`,
  `length` and `normalize` where their overload exists;
- one generated bundle, one compiler publication path and one headless Vulkan
  runner;
- exact accounting of every selected overload.

### Stage 2 — complete supported manifest

- all supported scalar/vector overloads;
- helpers, out parameters and generated adapters;
- matrices and quaternions;
- explicit capability disposition for `double` and other optional features;
- multiple domain and edge cases per operation family.

Completion means every supported manifest identity has at least one CPU case
and one GPU disposition. The total may include documented compiler or device
blockers, but it may not include unreported gaps.

## Work boundaries

- Do not change the public DeltaMaths API merely to make test generation easy.
- Do not change `DeltaShader.Contract` or create a second shader artifact ABI.
- Do not add a public generic maths-test runner to DeltaRender.
- Do not put Vulkan or shader references into DeltaMaths.
- Do not run performance benchmarks; this feature tests correctness.
- Do not claim whole-manifest parity from CPU reflection coverage, successful
  GLSL validation or a skipped GPU execution.

The first integration run is allowed to stop on a real compiler or Vulkan
blocker. It must preserve the partial report so ownership of the failure is
obvious.
