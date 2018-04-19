using System;
using BenchmarkDotNet.Running;

namespace BenchmarkTemplate {
    class Program {
        static void Main(string[] args) {
            BenchmarkRunner.Run<Test>(new MainConfig());
        }
    }
}
