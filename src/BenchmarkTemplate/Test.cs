using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace BenchmarkTemplate {
    public class Test {
        private static int[] s_intArray = Enumerable.Range(0, 100_000_000).ToArray();

        [Benchmark(OperationsPerInvoke = 100_000_000)]
        public int EqualityComparerInt32() {
            int[] items = s_intArray;

            for (int i = 0; i < items.Length; i++)
                if (EqualityComparer<int>.Default.Equals(items[i], -1))
                    return i;

            return -1;
        }
    }
}
