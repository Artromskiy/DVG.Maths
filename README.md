# KibiHex.Maths

A lightweight, engine-independent mathematics library for .NET.

KibiHex.Maths provides scalar math utilities, fixed-point arithmetic, strongly typed vectors, extensive swizzling, and an optional shader-like API. It does not depend on Unity, `System.Numerics`, or a particular game engine.

The runtime library targets `netstandard2.1`; its code generator is a separate .NET console application.

## Features

- `float`, `double`, `int`, `uint`, and deterministic `fix` mathematics
- 2D, 3D, and 4D vectors
- boolean vectors and mask operations
- arithmetic, bitwise, comparison, and conversion operators
- geometry and interpolation functions
- `xyzw`, `rgba`, and `stpq` swizzles
- zero-inserting underscore swizzles
- conventional C# and shader-like API styles
- generated vector implementation split into readable partial files
- no engine dependencies

## Vector types

KibiHex.Maths includes 18 vector types:

| Scalar | 2D | 3D | 4D |
| --- | --- | --- | --- |
| `bool` | `bool2` | `bool3` | `bool4` |
| `int` | `int2` | `int3` | `int4` |
| `uint` | `uint2` | `uint3` | `uint4` |
| `float` | `float2` | `float3` | `float4` |
| `double` | `double2` | `double3` | `double4` |
| `fix` | `fix2` | `fix3` | `fix4` |

Vectors provide component constructors, scalar constructors, dimension conversions, indexing, parsing, equality, comparison, and the operators appropriate for their scalar type.

```csharp
using KibiHex;

var position = new float3(10f, 20f, 30f);
var offset = new float3(1f, 0f, -2f);
var result = position + offset;

float x = result[0];
float3 copy = float3.Parse("11, 20, 28");
```

## Fixed-point arithmetic

`fix` is a signed 16.16 fixed-point number intended for simulations where repeatable numeric behaviour is more important than floating-point range.

It supports:

- arithmetic and comparison operators
- bitwise and shift operators
- conversion to and from common numeric types
- parsing and formatting
- scalar and vector math functions
- constants such as `Zero`, `One`, `Pi`, `E`, `MinValue`, and `MaxValue`

```csharp
using KibiHex;

fix speed = (fix)1.5f;
fix time = (fix)2;
fix distance = speed * time;

var direction = fix3.Normalize(new fix3(3, 0, 4));
```

## Swizzling

Every vector supports shader-style swizzles using the `xyzw`, `rgba`, and `stpq` alphabets.

```csharp
var value = new float3(3f, 1f, 5f);

float2 xy = value.xy;       // (3, 1)
float3 yzx = value.yzx;     // (1, 5, 3)
float4 xxxx = value.xxxx;   // (3, 3, 3, 3)

value.xy = new float2(8f, 9f);
```

An underscore inserts the scalar type's default value:

```csharp
float3 value = new float3(3f, 1f, 5f);
float3 padded = value._xy; // (0, 3, 1)
```

Only swizzles with distinct writable components have setters. Repeated and underscore components are read-only.

## Vector mathematics

Floating-point and fixed-point vectors provide functions including:

- `Length`, `SqrLength`
- `Distance`, `SqrDistance`
- `Dot` and three-dimensional `Cross`
- `Normalize`
- `FaceForward`, `Reflect`, `Refract`
- `ClampLength`, `MoveTowards`, `SmoothDamp`
- `Clamp`, `Abs`, `Sign`, `Min`, `Max`
- `Lerp`, `InvLerp`
- `Sqrt`, `InverseSqrt`
- exponential functions where supported by the scalar type

The functions are available directly on their vector type:

```csharp
float3 from = new float3(0f, 0f, 0f);
float3 to = new float3(10f, 5f, 0f);

float distance = float3.Distance(from, to);
float3 halfway = float3.Lerp(from, to, 0.5f);
float3 direction = float3.Normalize(to - from);
```

Integer vectors additionally provide remainder, bitwise, complement, and shift operators. Boolean vectors provide `Any` and `All`.

## `Maths`: conventional C# API

`Maths` is the regular PascalCase scalar API. It remains intentionally separate from generated vector overloads.

```csharp
using KibiHex;

float angle = Maths.Radians(90f);
float wave = Maths.Sin(angle);
float value = Maths.Clamp(wave, 0f, 1f);
```

It includes common interpolation, trigonometric, exponential, logarithmic, rounding, and mapping helpers for supported scalar types.

## `maths`: shader-like API

The generated lowercase `maths` class forwards scalar calls to `Maths` and adds vector overloads. Import it statically to write compact shader-like expressions without naming the class at each call:

```csharp
using KibiHex;
using static KibiHex.maths;

float3 a = new float3(0f, 0f, 0f);
float3 b = new float3(10f, 5f, 2f);

float3 point = lerp(a, b, 0.25f);
float3 normal = normalize(b - a);
float alignment = dot(normal, new float3(0f, 1f, 0f));
```

Both styles use the same implementations. Choose `Maths` and vector methods for conventional C#, or `using static KibiHex.maths` for concise mathematical code.

## Generated source layout

Vector source is generated as partial structs. Each concern has its own file:

```text
float3.cs
float3.operators.cs
float3.geometry.cs
float3.swizzles.cs
```

The declarative generator lives in the sibling `KibiHex.MathsGen` project. Running it with the vector output directory rewrites all generated files:

```bash
dotnet run --project ../MathsGen/KibiHex.MathsGen.csproj -- ./Vectors
```

The generator also creates:

- `maths.cs` from the public scalar methods of `Maths`
- `maths.vectors.cs` from vector declarations marked for the shader-like API

## Building

```bash
dotnet build KibiHex.Maths.csproj
```

To reference the project directly:

```xml
<ProjectReference Include="path/to/Maths/KibiHex.Maths.csproj" />
```

Then import the library namespace:

```csharp
using KibiHex;
```

## Design goals

- predictable numeric behaviour
- a small and portable runtime
- explicit, strongly typed vector APIs
- readable generated C#
- easy extension with new scalar and composite types
- compatibility with engine, tooling, client, and server projects
- familiar syntax without preserving a dependency on any shader language

KibiHex.Maths is intended as a practical mathematical foundation for simulations, games, custom engines, ECS code, physics, procedural systems, and server-side logic.
