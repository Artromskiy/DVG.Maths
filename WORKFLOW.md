# Maths workflow

From the workspace root, regenerate first when declarations changed:

```bash
dotnet MathsGen/bin/Release/net8.0/Delta.MathsGen.dll Maths/Vectors
dotnet build Maths/Delta.Maths.csproj -c Release -f netstandard2.0 \
  --disable-build-servers -m:1 /p:UseSharedCompilation=false
dotnet build Maths/Delta.Maths.csproj -c Release -f netstandard2.1 \
  --disable-build-servers -m:1 /p:UseSharedCompilation=false
dotnet run --project Maths/Tests/Delta.Maths.Tests.csproj -c Release
git -C Maths diff --check
```

Do not run version benchmarks during ordinary review. Use the manual workflow
only when the user asks for a version comparison.

## Code metrics

Run the manual GitHub Actions `Code metrics` workflow before committing a
substantial change, then inspect its SARIF and summary artifacts. The rules
CA1501/CA1502/CA1505/CA1506 are report-only signals; do not refactor a method
for one isolated warning. Refactor when several metrics remain over their
limits, the issue persists across runs, or profiling identifies a hot path.

For local application run `./eng/format.sh`; for a non-mutating check use
`FORMAT_CHECK=1 ./eng/format.sh`. Run the check before committing substantial
changes. The script uses the repository `.editorconfig` and `Directory.Build.props`.
It skips restore by default; use `FORMAT_RESTORE=1 ./eng/format.sh` only when
assets are missing or dependencies changed.
