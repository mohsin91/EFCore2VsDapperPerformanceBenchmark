``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 1 (10.0.14393)
Processor=Intel Core i5-6200U CPU 2.30GHz (Skylake), ProcessorCount=4
Frequency=2343749 Hz, Resolution=426.6668 ns, Timer=TSC
.NET Core SDK=2.0.0-preview2-006497
  [Host]     : .NET Core 2.0.0-preview2-25407-01 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0-preview2-25407-01 (Framework 4.6.00001.0), 64bit RyuJIT


```
 |                         Method |     Mean |     Error |    StdDev |
 |------------------------------- |---------:|----------:|----------:|
 | GetProductsWithEntityFramework | 29.11 ms | 0.4215 ms | 0.3943 ms |
 |          GetProductsWithDapper | 28.09 ms | 0.3729 ms | 0.3488 ms |
