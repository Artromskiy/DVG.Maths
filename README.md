---

# DVG.Math

A lightweight, engine-agnostic mathematics library for .NET.

This library provides fixed-point arithmetic, vector types, and a wide set of math utilities without any dependency on **System.Numerics**, **Unity**, or other game engines. It is designed for deterministic simulations, custom engines, server-side logic, and projects where full control over numeric behavior is required.

---

## ✨ Features

### ✔ No External Engine Dependencies

* No `System.Numerics`
* No Unity types
* Pure .NET implementation
* Suitable for runtime and server environments

### ✔ Fixed-Point Arithmetic (`fix`)

* 16.16 fixed-point implementation
* Deterministic and overflow-checked arithmetic
* Explicit/implicit conversions to and from:

  * `int`
  * `float`
  * `double`
  * `decimal`
* Software-based string formatting for deterministic output
* Constants: `Zero`, `One`, `MinValue`, `MaxValue`, `Pi`, `E`

Supports:

* Arithmetic operators (`+`, `-`, `*`, `/`, `%`)
* Bitwise operators (`&`, `|`, `^`, `~`, `<<`, `>>`)
* Comparison operators
* Increment / decrement
* Parsing and formatting
* Hashing and comparison

Designed for deterministic gameplay logic and lockstep simulations.

---

## 📐 Vector Types

The library includes scalar and vector types for multiple numeric formats:

### 2D

* `fix2`, `float2`, `double2`
* `int2`, `uint2`

### 3D

* `fix3`, `float3`, `double3`
* `int3`, `uint3`

### 4D

* `fix4`, `float4`, `double4`
* `int4`, `uint4`

### Common Vector Operations

* `Length`, `SqrLength`
* `Distance`, `SqrDistance`
* `Dot`, `Cross`
* `Normalize`
* `ClampLength`
* `MoveTowards`
* `RotateTowards`
* `Reflect`, `Refract`
* `FaceForward`
* `Lerp`, `Mix`, `SmoothStep`
* `SmoothDamp`, `SmoothDampAngle`
* `DeltaAngle`
* `Repeat`
* `Remap`

Comparison helpers:

* `LesserThan`, `GreaterThan`
* `Equal`, `NotEqual`
* etc.

---

## 🧮 Maths Utility Class

The `Maths` static class provides a consistent math API for:

* `float`
* `double`
* `int`
* `uint`
* `long`

### Included Functions

#### Interpolation & Mapping

* `Lerp`
* `InvLerp`
* `SmoothStep`
* `Step`
* `Remap`
* `Mix`

#### Trigonometry

* `Sin`, `Cos`, `Tan`
* `Asin`, `Acos`, `Atan`, `Atan2`
* Hyperbolic functions
* `Radians`, `Degrees`

#### Exponential & Logarithmic

* `Pow`
* `Exp`, `Exp2`
* `Log`, `Log2`, `Log10`
* `Sqrt`, `InverseSqrt`
* `Cbrt`

#### Rounding & Precision

* `Floor`
* `Ceil`
* `Round`
* `RoundEven`
* `Truncate`
* `Fract`
* `Mod`
* `Fma`

#### Utility

* `Min`, `Max`, `Clamp`
* `Abs`, `Sign`
* Bit conversions:

  * `FloatBitsToInt`
  * `FloatBitsToUInt`
  * `IntBitsToFloat`
  * `UIntBitsToFloat`
* `IsNaN`
* `IsInfinity`

The API is designed to feel familiar to developers coming from GLSL, HLSL, Unity.Mathematics, or System.Math — while remaining completely independent.

---

## 🎯 Use Cases

* Deterministic multiplayer games (lockstep / rollback)
* Custom game engines
* ECS-based architectures
* Server-side simulations
* Physics logic
* Tools that require predictable numeric behavior
* Projects where floating-point nondeterminism is unacceptable

---

## 🧩 Design Goals

* Determinism
* Explicit numeric control
* Minimal dependencies
* High inlining potential
* Familiar API surface
* Engine independence

---

## Example

```csharp
using DVG;

fix a = (fix)1.5f;
fix b = (fix)2;

fix result = a * b;

fix2 position = new fix2(a, b);
fix length = position.Length();

float angle = Maths.Radians(90f);
```

---

If you are building systems where numeric behavior matters — especially in multiplayer or simulation-heavy environments — this library aims to give you predictable, portable math without hidden engine assumptions.
