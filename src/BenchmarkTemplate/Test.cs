using System.Collections.Generic;
using System.IO;
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

        private const int Items = 3_000;
        private static readonly Dictionary<int, int> s_dict = Enumerable.Range(0, Items).ToDictionary(i => i);

        [Benchmark(OperationsPerInvoke = Items)]
        public int DictionaryContainsValue() {
            Dictionary<int, int> d = s_dict;
            int count = 0;

            for (int i = 0; i < Items; i++)
                if (d.ContainsValue(i))
                    count++;

            return count;
        }

        [Benchmark(OperationsPerInvoke = 10_000)]
        public bool EnumHasFlag() {
            FileAccess value = FileAccess.ReadWrite;
            bool result = true;

            for (int i = 0; i < 10_000; i++) {
                result &= value.HasFlag(FileAccess.Read);
            }

            return result;
        }

        [Benchmark(OperationsPerInvoke = 10_000_000)]
        public int LoweringTESTtoBT() {
            int y = 0, x = 0;

            while (x++ < 10_000_000)
                if ((x & (1 << y)) == 0)
                    y++;

            return y;
        }

        [Benchmark]
        public void BoxingAllocations() => BoxingAllocations(default(Dog));

        private void BoxingAllocations<T>(T thing) {
            if (thing is IAnimal)
                ((IAnimal)thing).MakeSound();
        }

        private struct Dog : IAnimal {
            public void Bark() { }
            void IAnimal.MakeSound() => Bark();
        }

        private interface IAnimal {
            void MakeSound();
        }
    }
}
