# Delta.Maths

Portable engine-independent mathematics for .NET. Runtime targets
`netstandard2.0` and `netstandard2.1` and has no Unity, renderer or
`System.Numerics` dependency.

The API includes scalar utilities and deterministic 16.16 `fix`,
`bool/int/uint/float/double/fix` vectors, geometry/interpolation/trigonometry,
swizzles, generated `float4x4` and `quaternion`, plus conventional `Maths.*`
and shader-like lowercase `maths.*` entry points.

```csharp
using Delta.Maths;
using static Delta.Maths.maths;

var direction = normalize(new float3(1f, 2f, 3f));
var transform = float4x4.CreateTRS(position, rotation, scale);
```

`float4x4` is column-major as four sequential `float4` columns. Translation is
in `c3.xyz`; column vectors are used and `T * R * S` applies scale, rotation,
then translation. CPU code, GLSL and std430 share this convention.

`Vectors/shader-contract.json` is generated from the same declarations and is
the only Maths symbol/layout source for DeltaShader. `double` and `fix` remain
CPU-only; GPU-only intrinsics stay in DeltaShader.

See [WORKFLOW.md](WORKFLOW.md) for generation/build/test commands,
[TODO.md](TODO.md) for selected work and [AGENTS.md](AGENTS.md) for routing.
