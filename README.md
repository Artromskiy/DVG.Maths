# DeltaMaths

DeltaMaths is a portable .NET mathematics library for game, rendering and
shader-support code.

## What it provides

DeltaMaths provides value-based scalar, vector, matrix and quaternion
operations with predictable CPU and shader-facing semantics.

## Quick start

```xml
<PackageReference Include="DeltaMaths" Version="0.0.9" />
```

```csharp
using Delta.Maths;
using static Delta.Maths.maths;

float3 direction = normalize(new float3(1f, 2f, 3f));
float4 transformed = new float4x4(1f) * new float4(direction, 1f);
```

## Core concepts

Vectors are value types with component-wise operations. Matrices use column
vectors and column-major storage, so matrix multiplication and layout match the
published shader contract.

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

## Packages and examples

Install `DeltaMaths` for runtime use. The generated contract is consumed by
shader tooling; the [DeltaMathsGen](../DeltaMathsGen/README.md) page explains
the separate source generator.

## Further reading

- [Public API and conventions](docs/README.md)
- [CPU/GPU conformance](docs/CPU_GPU_CONFORMANCE.md)
- [Generated shader contract](src/DeltaMaths/Vectors/shader-contract.json)
- [DeltaMathsGen](../DeltaMathsGen/README.md)
