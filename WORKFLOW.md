# DeltaMaths workflow

## Repository layout gate

The repository must follow the shared first-party layout documented in the
Furnace project standard. Before restore/build or a structural handoff, run:

```bash
./eng/check-layout.sh
```

The gate checks the mandatory top-level directories, rejects unexpected
top-level folders, requires `src/DeltaMaths/` as the primary source project,
and requires source siblings to use the `src/DeltaMaths.<Area>/` form.
`samples/` contains runnable examples; `probes/` contains bounded
headless/compiler/contract checks. Empty mandatory domains stay tracked with
`.gitkeep`.

From the DeltaMaths repository root, regenerate first when declarations
changed. Never run an unverified stale generator binary:

```bash
dotnet build ../DeltaMathsGen/src/DeltaMathsGen/DeltaMathsGen.csproj -c Release \
  --disable-build-servers -m:1 /p:UseSharedCompilation=false
dotnet ../DeltaMathsGen/src/DeltaMathsGen/bin/Release/net8.0/DeltaMathsGen.dll src/DeltaMaths/Vectors
dotnet ../DeltaMathsGen/src/DeltaMathsGen/bin/Release/net8.0/DeltaMathsGen.dll src/DeltaMaths/Vectors
dotnet build src/DeltaMaths/DeltaMaths.csproj -c Release -f netstandard2.0 \
  --disable-build-servers -m:1 /p:UseSharedCompilation=false
dotnet build src/DeltaMaths/DeltaMaths.csproj -c Release -f netstandard2.1 \
  --disable-build-servers -m:1 /p:UseSharedCompilation=false
dotnet run --project Tests/DeltaMaths.Tests/DeltaMaths.Tests.csproj -c Release
git diff --check
```

The second generation must produce no additional diff. Inspect
`.delta-generated-files` and `src/DeltaMaths/Vectors/shader-contract.json` for ABI/layout
changes before consumer verification.

DeltaMaths owns shader-visible types and contract metadata only. It does not
publish compiled shader outputs. All generated `.spv`, `.glsl` and shader
manifest files belong to the single DeltaShader catalog at
`../DeltaShader/src/DeltaShader/CompiledShaders`; do not create a Maths-local
compiled-shader directory or mix lock files into that catalog.

Do not run version benchmarks during ordinary review. Use the manual workflow
only when the user asks for a version comparison.

## Code metrics

Run the same analyzer/code-metrics build locally and in the manual GitHub
Actions workflow through the repository wrapper:

```bash
./eng/code-metrics.sh -v:q
```

`eng/code-metrics.sh` converts `CODE_METRICS_ERROR_LOG` (default:
`artifacts/code-metrics/diagnostics.sarif`) to an absolute path before
MSBuild starts, so multi-project builds write one repository-level SARIF
instead of resolving a missing directory relative to each project. An
explicit destination is supported:

```bash
CODE_METRICS_ERROR_LOG=/tmp/code-metrics.sarif ./eng/code-metrics.sh -v:q
```

Inspect the SARIF and summary artifacts from the manual workflow. The rules
CA1501/CA1502/CA1505/CA1506 are report-only signals; do not refactor a method
for one isolated warning. Refactor when several metrics remain over their
limits, the issue persists across runs, or profiling identifies a hot path.

For local application run `./eng/format.sh`; for a non-mutating check use
`FORMAT_CHECK=1 ./eng/format.sh`. The script uses `dotnet format whitespace
--folder` to avoid the MSBuild/Roslyn workspace load that can hang on macOS
with .NET 10. It checks/applies whitespace only; analyzer/style diagnostics
remain covered by the build and SARIF metrics workflow.
