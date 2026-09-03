# DeltaMaths

DeltaMaths is a portable mathematics library for .NET game, rendering and
shader-support code.

## What it provides

- Scalar functions, interpolation and geometry operations.
- `bool`, integer, floating-point, double, half and fixed-point vector types.
- Swizzles, component-wise arithmetic and selection operations.
- GLSL-shaped float and double matrix families, including rectangular matrices.
- Quaternion construction, rotation and interpolation.
- A lowercase `maths` façade for shader-like application code.
- Explicit CPU/GLSL layout and symbol metadata for shader consumers.

## Quick start

```xml
<PackageReference Include="DeltaMaths" Version="0.0.10" />
```

```csharp
using Delta;
using static Delta.maths;

float3 direction = normalize(new float3(1f, 2f, 3f));
float4 transformed = new float4x4(1f) * new float4(direction, 1f);
```

The API uses column vectors and column-major matrix storage. `float4x4` stores
four sequential `float4` columns, translation is in the fourth column, and
`CreateTRS` applies scale, rotation, then translation.

## Capabilities and limits

The package targets `netstandard2.0`, `netstandard2.1`, `net8.0` and `net10.0`.
Fixed-point values are CPU-oriented; shader consumers must support the
capability required by each floating-point type. GPU-only operations remain
owned by the shader toolchain.

## Packages and examples

Install `DeltaMaths` for the runtime API. Shader consumers use the generated
[shader contract](../src/DeltaMaths/Vectors/shader-contract.json) to resolve
symbols and layouts.

## Further reading

- [CPU/GPU conformance](CPU_GPU_CONFORMANCE.md)
- [Shader contract](../src/DeltaMaths/Vectors/shader-contract.json)
- [DeltaMathsGen](../../DeltaMathsGen/README.md)
