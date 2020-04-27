``` ini

BenchmarkDotNet=v0.12.1, OS=fedora 30
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  DefaultJob : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT


```
|                        Method |     Mean |     Error |    StdDev |   Median |
|------------------------------ |---------:|----------:|----------:|---------:|
|      AccessWithTypeDescriptor | 3.467 μs | 0.0292 μs | 0.0244 μs | 3.459 μs |
| SingleAccessWithGetProperties | 1.526 μs | 0.0125 μs | 0.0104 μs | 1.523 μs |
|      NewAccessPerPropertyName | 1.839 μs | 0.0367 μs | 0.1012 μs | 1.806 μs |
