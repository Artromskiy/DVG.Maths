# CPU conformance case bundle

The bundle is generated from `src/DeltaMaths/Vectors/shader-contract.json` under
protocol `math-cpu-gpu-conformance-v0.1`. Its compatibility checkpoint is
`ea92fad`. Each case invokes the exact CLR overload selected by the complete
manifest identity; the input and result are stored as canonical hexadecimal
words.

| Manifest accounting | Count |
|---|---:|
| Manifest functions | 2443 |
| Supported (`Builtin` or `Helper`) | 893 |
| CPU cases | 893 |
| Explicitly excluded supported cases | 0 |
| Unsupported manifest functions | 1550 |

Every supported manifest identity has one deterministic nominal case. The
bundle records the operation identity, mapping, input/expected words, named
comparison profile with tolerances, required capability, shader stages, and
CPU/Shader/Render disposition. `cpu=ready` means exact CLR evaluation only;
`shader=pending` and `render=pending` deliberately do not claim GPU parity.

The checked-in bundle is validated during the normal Conformance run. Repeated
generation is deterministic and currently produces SHA-256
`7022b95ab4093776182fe493c34c67a17a3bce400d6aec327a8dfca45b782fd1`.
