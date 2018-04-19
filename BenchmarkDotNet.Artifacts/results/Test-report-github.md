``` ini

BenchmarkDotNet=v0.10.14, OS=macOS High Sierra 10.13.3 (17D102) [Darwin 17.4.0]
Intel Core i5-7360U CPU 2.30GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.300-preview1-008174
  [Host]     : .NET Core 2.0.5 (CoreCLR 4.6.0.0, CoreFX 4.6.26018.01), 64bit RyuJIT
  Job-ARCTPB : .NET Core 2.0.5 (CoreCLR 4.6.0.0, CoreFX 4.6.26018.01), 64bit RyuJIT
  Job-PYQSUL : .NET Core 2.1.0-preview1-26216-03 (CoreCLR 4.6.26216.04, CoreFX 4.6.26216.02), 64bit RyuJIT


```
|                Method |     Toolchain |      Mean | Allocated |
|---------------------- |-------------- |----------:|----------:|
| EqualityComparerInt32 | .NET Core 2.0 | 2.1762 ns |       0 B |
| EqualityComparerInt32 | .NET Core 2.1 | 0.7647 ns |       0 B |
