``` ini

BenchmarkDotNet=v0.12.1, OS=fedora 30
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.200
  [Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
  DefaultJob : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT


```
|                                           Method |     Mean |     Error |    StdDev |
|------------------------------------------------- |---------:|----------:|----------:|
|                               WithTypeDescriptor | 3.789 μs | 0.0719 μs | 0.0706 μs |
|                            WithoutTypeDescriptor | 2.014 μs | 0.0231 μs | 0.0216 μs |
| WithoutTypeDescriptorAndNewAccessPerPropertyName | 2.183 μs | 0.0430 μs | 0.0512 μs |
