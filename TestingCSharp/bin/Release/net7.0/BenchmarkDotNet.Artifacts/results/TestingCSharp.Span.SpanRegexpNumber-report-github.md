``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|       Method |       N |       Mean |     Error |    StdDev |   Gen0 | Allocated |
|------------- |-------- |-----------:|----------:|----------:|-------:|----------:|
|         **Linq** |     **100** | **19.6696 ns** | **0.4207 ns** | **0.3935 ns** | **0.0076** |      **64 B** |
|         Span |     100 |  0.9369 ns | 0.0328 ns | 0.0290 ns |      - |         - |
| Span_Checked |     100 |  0.8207 ns | 0.0188 ns | 0.0167 ns |      - |         - |
|         **Linq** |   **10000** | **17.6510 ns** | **0.2084 ns** | **0.1740 ns** | **0.0076** |      **64 B** |
|         Span |   10000 |  1.0441 ns | 0.0132 ns | 0.0117 ns |      - |         - |
| Span_Checked |   10000 |  0.9459 ns | 0.0495 ns | 0.0678 ns |      - |         - |
|         **Linq** | **1000000** | **17.9100 ns** | **0.2253 ns** | **0.1881 ns** | **0.0076** |      **64 B** |
|         Span | 1000000 |  0.9807 ns | 0.0486 ns | 0.0499 ns |      - |         - |
| Span_Checked | 1000000 |  0.8414 ns | 0.0466 ns | 0.0622 ns |      - |         - |
