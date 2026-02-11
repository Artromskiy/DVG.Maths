---

# DVG.Maths

A lightweight, engine-agnostic mathematics library for .NET.

This library provides fixed-point arithmetic, vector types, swizzling support, and a wide set of math utilities without any dependency on **System.Numerics**, **Unity**, or other game engines. It is designed for deterministic simulations, custom engines, server-side logic, and projects where full control over numeric behavior is required.

---

## ✨ Features

### ✔ No External Engine Dependencies

* No `System.Numerics`
* No Unity types
* Pure .NET implementation
* Suitable for runtime and server environments

---

## 🔢 Fixed-Point Arithmetic (`fix`)

A 16.16 fixed-point implementation focused on deterministic behavior.

### Characteristics

* 16-bit integer part, 16-bit fractional part
* Overflow-checked arithmetic
* Deterministic string formatting (via `decimal`)
* Explicit/implicit conversions to and from:

  * `int`
  * `float`
  * `double`
  * `decimal`

### Constants

* `Zero`
* `One`
* `MinValue`
* `MaxValue`
* `Pi`
* `E`

### Supported Operations

* Arithmetic operators (`+`, `-`, `*`, `/`, `%`)
* Bitwise operators (`&`, `|`, `^`, `~`, `<<`, `>>`)
* Comparison operators
* Increment / decrement
* Parsing (`Parse`)
* Hashing and comparison

Ideal for deterministic gameplay logic, lockstep multiplayer, and simulation systems.

---

## 📐 Vector Types

The library provides vector types for multiple numeric formats.

### Boolean Vectors

* `bool2`
* `bool3`
* `bool4`

Useful for:

* Masking
* Per-component comparisons
* SIMD-like logic patterns
* Branch-free math flows

---

### 2D

* `fix2`, `float2`, `double2`
* `int2`, `uint2`
* `bool2`

### 3D

* `fix3`, `float3`, `double3`
* `int3`, `uint3`
* `bool3`

### 4D

* `fix4`, `float4`, `double4`
* `int4`, `uint4`
* `bool4`

---

## 🔁 Swizzling

Swizzling is supported up to 4 dimensions.

You can reorder components or construct new vectors from existing ones in a familiar shader-style way.

Examples:

```csharp
fix3 v = new fix3(3, 1, 5);

var xy = v.xy;      // fix2(3, 1)
var yzx = v.yzx;    // fix3(1, 5, 3)
var xxxx = v.xxxx;  // fix4(3, 3, 3, 3)
```

### Zero-Swizzle Support

Special underscore-prefixed swizzles allow injecting zero into specific components.

Example:

```csharp
fix3 v = new fix3(3, 1, 5);

var result = v._xy;   // fix3(0, 1, 5)
```

This allows convenient construction of partially zeroed vectors without extra allocations or helper calls.

Swizzling is available up to 4 components.

---

## 📊 Common Vector Operations

Across numeric vector types:

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

* `LesserThan`, `LesserThanEqual`
* `GreaterThan`, `GreaterThanEqual`
* `Equal`, `NotEqual`

---

## 🧮 Maths Utility Class

The `Maths` static class provides a consistent math API for:

* `float`
* `double`
* `int`
* `uint`
* `long`

### Interpolation & Mapping

* `Lerp`
* `InvLerp`
* `SmoothStep`
* `Step`
* `Remap`
* `Mix`

### Trigonometry

* `Sin`, `Cos`, `Tan`
* `Asin`, `Acos`, `Atan`, `Atan2`
* Hyperbolic functions
* `Radians`, `Degrees`

### Exponential & Logarithmic

* `Pow`
* `Exp`, `Exp2`
* `Log`, `Log2`, `Log10`
* `Sqrt`, `InverseSqrt`
* `Cbrt`

### Rounding & Precision

* `Floor`
* `Ceil`
* `Round`
* `RoundEven`
* `Truncate`
* `Fract`
* `Mod`
* `Fma`

### Utility

* `Min`, `Max`, `Clamp`
* `Abs`, `Sign`
* Bit conversions:

  * `FloatBitsToInt`
  * `FloatBitsToUInt`
  * `IntBitsToFloat`
  * `UIntBitsToFloat`
* `IsNaN`
* `IsInfinity`

The API is intentionally familiar to developers coming from GLSL, HLSL, Unity.Mathematics, or System.Math — while remaining completely independent.

---

## 🎯 Use Cases

* Deterministic multiplayer games (lockstep / rollback)
* ECS-based architectures
* Custom engines
* Server-side simulations
* Physics logic
* Tools requiring predictable numeric behavior
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

fix3 position = new fix3(a, b, fix.One);
fix length = position.Length();

float angle = Maths.Radians(90f);
```

---

If you are building systems where numeric behavior must be predictable — especially in multiplayer or simulation-heavy environments — this library provides a portable and deterministic math foundation without engine constraints.
