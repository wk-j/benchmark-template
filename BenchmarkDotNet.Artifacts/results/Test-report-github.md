``` ini

BenchmarkDotNet=v0.10.14, OS=macOS High Sierra 10.13.3 (17D102) [Darwin 17.4.0]
Intel Core i5-7360U CPU 2.30GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.300-preview1-008174
  [Host]     : .NET Core 2.0.5 (CoreCLR 4.6.0.0, CoreFX 4.6.26018.01), 64bit RyuJIT
  Job-OTOLSD : .NET Core 2.0.5 (CoreCLR 4.6.0.0, CoreFX 4.6.26018.01), 64bit RyuJIT
  Job-JTCOCT : .NET Core 2.1.0-preview1-26216-03 (CoreCLR 4.6.26216.04, CoreFX 4.6.26216.02), 64bit RyuJIT


```
| Method |     Toolchain |      Mean |  Gen 0 | Allocated |
|------- |-------------- |----------:|-------:|----------:|
|      A | .NET Core 2.0 |  6.223 ns | 0.0229 |      48 B |
|      B | .NET Core 2.0 | 19.585 ns | 0.0686 |     144 B |
|      A | .NET Core 2.1 |  6.161 ns | 0.0229 |      48 B |
|      B | .NET Core 2.1 | 19.572 ns | 0.0686 |     144 B |
