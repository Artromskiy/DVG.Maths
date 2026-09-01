# CPU conformance case bundle

The bundle is generated from `src/DeltaMaths/Vectors/shader-contract.json` under
protocol `math-cpu-gpu-conformance-v0.1`. Its compatibility checkpoint is
`ea92fad`. Each case invokes the exact CLR overload selected by the complete
manifest identity; the input and result are stored as canonical hexadecimal
words.

| Manifest accounting | Count |
|---|---:|
| Manifest functions | 3808 |
| Supported (`Builtin` or `Helper`) | 2343 |
| CPU cases | 2343 |
| Explicitly excluded supported cases | 0 |
| Unsupported manifest functions | 1465 |

Every supported manifest identity has one deterministic nominal case. The
bundle records the operation identity, mapping, input/expected words, named
comparison profile with tolerances, required capability, shader stages, and
CPU/Shader/Render disposition. `cpu=ready` means exact CLR evaluation only;
`shader=pending` and `render=pending` deliberately do not claim GPU parity.

The checked-in bundle is validated during the normal Conformance run. Repeated
generation is deterministic and currently produces SHA-256
`bffa2925ce4a6491ce70cfd4492b7cc9eebbcd6b1d9815000c359a92f6bdf0b9`.
