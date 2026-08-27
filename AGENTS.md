# DeltaMaths agent guide

Scope: portable engine-independent runtime maths and its generated shader
symbol/layout contract.

- [README.md](README.md) — stable API and matrix convention.
- [TODO.md](TODO.md) — selected work.
- [IDEAS.md](IDEAS.md) — deferred research only.
- [WORKFLOW.md](WORKFLOW.md) — generation, target builds and tests.
- [CPU_GPU_CONFORMANCE.md](CPU_GPU_CONFORMANCE.md) — authoritative CPU/Shader/Vulkan
  differential-conformance protocol and ownership split.
- [../DeltaMathsGen/AGENTS.md](../DeltaMathsGen/AGENTS.md) — required for generated API
  changes; [../DeltaShader/AGENTS.md](../DeltaShader/AGENTS.md) — required when
  shader-visible identities or layouts change.
- [../HIGH_PRIORITY_TODO.md](../HIGH_PRIORITY_TODO.md) — deterministic
  generation/ABI lane.

Generated files are never edited directly. Preserve `netstandard2.0/2.1`,
std430 compatibility and the shared CPU/GLSL column-vector convention.

Skills: `vectorization` or `simd-intrinsics` for measured numeric hot paths,
`abi-and-calling-conventions` for layouts, `shader-dev` for shader mappings,
and `performance-benchmark` only for a bounded explicit comparison.
