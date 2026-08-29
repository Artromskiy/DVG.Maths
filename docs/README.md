# DeltaMaths

Portable engine-independent mathematics for .NET. Runtime targets
`netstandard2.0`, `netstandard2.1`, `net8.0` and `net10.0`, and has no Unity,
renderer or `System.Numerics` dependency.

The API includes scalar utilities and deterministic 16.16 `fix`,
`bool/int/uint/float/double/fix` vectors, geometry/interpolation/trigonometry,
swizzles, generated GLSL-compatible single-precision matrices and `quaternion`,
plus normalized GLSL pack/unpack operations for `float2` and `float4`. It also
provides conventional `DeltaMaths.*` and shader-like lowercase `maths.*` entry
points.

`fix` stores a signed 16.16 value. Its public `raw` field is intentionally
retained as a narrow ABI and serialization escape hatch for existing
integrations; ordinary code should use the typed conversions and operators.

```csharp
using Delta.Maths;
using static Delta.Maths.maths;

var direction = normalize(new float3(1f, 2f, 3f));
var transform = float4x4.CreateTRS(position, rotation, scale);
```

The nine single-precision matrix types are named `floatCxR`, matching GLSL's
`matCxR`: C is the number of columns and R is the number of rows. Each matrix
stores sequential column vectors (`c0`, `c1`, ...), so `M * v` uses column
vectors and matches GLSL 4.60. In std430, a `float3` column has a 16-byte
stride and the generated value contains explicit padding; the manifest records
the column count, row count, alignment, stride and total size. Square matrices
also provide `determinant`, `inverse` and a safe `TryInverse`; every matrix
provides arithmetic, matrix/vector multiplication, `transpose`,
`matrixCompMult` and `outerProduct`.

Each matrix has constructors from its column vectors, a diagonal scalar, all
row-major `Mij` scalar components, and every other generated float matrix. The
matrix-to-matrix constructor follows GLSL conversion rules: overlapping
columns and rows are copied, missing off-diagonal elements are zero, and a
missing diagonal element is one. The `Mij` scalar constructor retains the CLR
row-major parameter order for compatibility; use the column constructor when
spelling a GLSL column-major scalar sequence explicitly.

`float4x4` is column-major as four sequential `float4` columns. Translation is
in `c3.xyz`; `T * R * S` applies scale, rotation, then translation. CPU code,
GLSL and std430 share this convention.

[`src/DeltaMaths/Vectors/shader-contract.json`](../src/DeltaMaths/Vectors/shader-contract.json)
is generated from the same declarations and is the committed generated
DeltaMaths ABI consumed and validated by DeltaShader. DeltaMathsGen owns its
declarations/generation; neither DeltaMaths nor DeltaShader recreates it.
`double` and `fix` remain CPU-only; GPU-only intrinsics stay in DeltaShader.

See [CPU_GPU_CONFORMANCE.md](CPU_GPU_CONFORMANCE.md) for the
cross-project CPU/Shader/Vulkan correctness protocol. Its bundles are test
tooling, not part of the runtime DeltaMaths API.

See [WORKFLOW.md](../WORKFLOW.md) for generation/build/test commands,
[TODO.md](../TODO.md) for selected work and [AGENTS.md](../AGENTS.md) for routing.
