# DeltaMaths.Conformance

CPU-only deterministic conformance checks for the public Delta.Maths API.
This project does not reference DeltaShader or DeltaRender. It is the CPU
oracle for later shader lowering and GPU readback tests.

The run also loads `Vectors/shader-contract.json` and executes one case for
every supported `Builtin` or `Helper` overload. The generated case list must
match the manifest exactly; missing or extra cases fail the run. Regenerate the
case source after a contract change with:

```bash
python3 Tests/DeltaMaths.Conformance/GenerateContractCases.py
```

Run it with:

```bash
dotnet run --project Tests/DeltaMaths.Conformance/DeltaMaths.Conformance.csproj -c Release
```

Generate the versioned deterministic CPU case bundle with the exact CLR
overload as its oracle:

```bash
dotnet run --project Tests/DeltaMaths.Conformance/DeltaMaths.Conformance.csproj -c Release \
  -- --write-bundle Tests/DeltaMaths.Conformance/shader-conformance.json
```

The bundle is test data, not a GPU result. It records the complete supported
manifest identity, canonical hexadecimal words for inputs and CPU expected
values, comparison profiles, capabilities, stages, and explicit CPU/Shader/
Render dispositions. The normal run validates the checked-in bundle against
the current manifest and exact CLR overloads. A finite reflection invocation is
only manifest reachability coverage; it is not a proof of numerical parity.

The generated counts and bundle hash are recorded in
`shader-conformance-report.md`.
