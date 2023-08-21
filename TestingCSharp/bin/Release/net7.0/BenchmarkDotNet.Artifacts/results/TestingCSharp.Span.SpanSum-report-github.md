``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|       Method |       N |     Mean |    Error |   StdDev | Allocated |
|------------- |-------- |---------:|---------:|---------:|----------:|
|         **Linq** |     **100** | **42.77 ns** | **0.687 ns** | **0.537 ns** |         **-** |
|         Span |     100 | 41.00 ns | 0.851 ns | 2.135 ns |         - |
| Span_Checked |     100 | 44.78 ns | 0.916 ns | 1.479 ns |         - |
|         **Linq** |   **10000** | **46.55 ns** | **0.953 ns** | **1.967 ns** |         **-** |
|         Span |   10000 | 40.41 ns | 0.847 ns | 1.319 ns |         - |
| Span_Checked |   10000 | 45.42 ns | 0.943 ns | 2.750 ns |         - |
|         **Linq** | **1000000** | **45.74 ns** | **0.949 ns** | **2.162 ns** |         **-** |
|         Span | 1000000 | 40.77 ns | 0.838 ns | 2.040 ns |         - |
| Span_Checked | 1000000 | 41.21 ns | 0.748 ns | 0.700 ns |         - |
