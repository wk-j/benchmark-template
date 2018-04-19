#addin "wk.StartProcess"

using PS = StartProcess.Processor;

Task("Start").Does(() => {
    PS.StartProcess("dotnet run -c Release -f netcoreapp2.0 --project src/BenchmarkTemplate");
});

var target = Argument("target", "Start");
RunTarget(target);