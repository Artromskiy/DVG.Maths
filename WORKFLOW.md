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
