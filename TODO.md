# DeltaMaths TODO

Consumer requests that add a generated type or function start in DeltaMathsGen and
include shader-contract tests when the symbol is GPU-visible. The committed
`shader-contract.json` is generated ABI consumed by DeltaShader, not a
contract that DeltaMaths or Shader recreates independently.

The selected GLSL 4.60 contract backlog is maintained in
[DeltaMathsGen/TODO.md](../DeltaMathsGen/TODO.md#glsl-460-contract-gaps): pure
function metadata, integer operators, optional double precision, and the
explicit boundary between Delta.Maths and stage/resource features owned by
DeltaShader/DeltaRender. The public Delta spelling for boolean-mask selection
is `select`; it must not be duplicated with a `mix` alias.
