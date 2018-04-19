using System.Collections.Generic;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Reports;

namespace BenchmarkTemplate {
    sealed class MinimalColumnProvider : IColumnProvider {

        public IEnumerable<IColumn> GetColumns(Summary summary) {
            yield return TargetMethodColumn.Method;
            yield return new JobCharacteristicColumn(InfrastructureMode.ToolchainCharacteristic);
            yield return StatisticColumn.Mean;
        }
    }
}