using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Toolchains.CsProj;

namespace BenchmarkTemplate {
    public class MainConfig : ManualConfig {
        public MainConfig() {
            Add(Job.Default.With(Platform.X64).With(CsProjCoreToolchain.NetCoreApp20));
            Add(Job.Default.With(Platform.X64).With(CsProjCoreToolchain.NetCoreApp21));

            Add(MemoryDiagnoser.Default);
            Add(new MinimalColumnProvider());
            Add(MemoryDiagnoser.Default.GetColumnProvider());
            // Set(new DefaultOrderProvider(SummaryOrderPolicy.SlowestToFastest));
            Add(MarkdownExporter.GitHub);
            Add(new ConsoleLogger());
        }
    }
}