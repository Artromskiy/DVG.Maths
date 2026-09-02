# DeltaMaths

DeltaMaths is a portable .NET mathematics library for game, rendering and
shader-support code.

## Quick start

```xml
<PackageReference Include="DeltaMaths" Version="0.0.7" />
```

```csharp
using Delta.Maths;
using static Delta.Maths.maths;

float3 direction = normalize(new float3(1f, 2f, 3f));
float4 transformed = new float4x4(1f) * new float4(direction, 1f);
```

## Capabilities and limits

- Scalar functions, interpolation, geometry and quaternion operations.
- Integer, floating-point, double, half and fixed-point vectors.
- GLSL-shaped float and double matrices, including rectangular matrices.
- Column-vector, column-major matrix storage compatible with the published
  shader contract.
- Targets: `netstandard2.0`, `netstandard2.1`, `net8.0` and `net10.0`.

Fixed-point values are CPU-oriented. Device and compiler support for shader
types is decided by the shader consumer; GPU-only intrinsics are outside this
package.

## Further reading

- [Public API and conventions](docs/README.md)
- [CPU/GPU conformance](docs/CPU_GPU_CONFORMANCE.md)
- [Generated shader contract](src/DeltaMaths/Vectors/shader-contract.json)
- [DeltaMathsGen](../DeltaMathsGen/README.md)
