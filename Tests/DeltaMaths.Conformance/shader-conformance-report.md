# CPU conformance case bundle

The bundle is generated from `Vectors/shader-contract.json` at checkpoint
`ea92fad` under protocol `math-cpu-gpu-conformance-v0.1`. Each case invokes the
exact CLR overload selected by the complete manifest identity; the input and
result are stored as canonical hexadecimal words.

| Manifest accounting | Count |
|---|---:|
| Manifest functions | 2103 |
| Supported (`Builtin` or `Helper`) | 551 |
| CPU cases | 551 |
| Explicitly excluded supported cases | 0 |
| Unsupported manifest functions | 1552 |

Every supported manifest identity has one deterministic nominal case. The
bundle records the operation identity, mapping, input/expected words, named
comparison profile with tolerances, required capability, shader stages, and
CPU/Shader/Render disposition. `cpu=ready` means exact CLR evaluation only;
`shader=pending` and `render=pending` deliberately do not claim GPU parity.

The checked-in bundle is validated during the normal Conformance run. Repeated
generation is deterministic and currently produces SHA-256
`4a574aa4ea99c2ceb4293bb4d3154dcfa6ea7ef8c9315d14a30c8b8e04ae6c64`.
