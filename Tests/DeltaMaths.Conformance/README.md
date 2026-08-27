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
