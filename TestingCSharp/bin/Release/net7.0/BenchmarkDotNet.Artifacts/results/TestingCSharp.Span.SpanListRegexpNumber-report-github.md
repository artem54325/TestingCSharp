``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|           Method |       N |      Mean |     Error |    StdDev |   Gen0 | Allocated |
|----------------- |-------- |----------:|----------:|----------:|-------:|----------:|
|             **Linq** |     **100** | **25.719 ns** | **0.4739 ns** | **0.4433 ns** | **0.0124** |     **104 B** |
|         Readonly |     100 | 21.468 ns | 0.4398 ns | 0.4320 ns | 0.0076 |      64 B |
| Readonly_Checked |     100 | 22.226 ns | 0.3609 ns | 0.3376 ns | 0.0076 |      64 B |
|             Span |     100 |  1.909 ns | 0.0449 ns | 0.0398 ns |      - |         - |
|             **Linq** |   **10000** | **25.502 ns** | **0.2960 ns** | **0.2624 ns** | **0.0124** |     **104 B** |
|         Readonly |   10000 | 20.838 ns | 0.3459 ns | 0.2889 ns | 0.0076 |      64 B |
| Readonly_Checked |   10000 | 21.287 ns | 0.3981 ns | 0.3529 ns | 0.0076 |      64 B |
|             Span |   10000 |  1.859 ns | 0.0426 ns | 0.0399 ns |      - |         - |
|             **Linq** | **1000000** | **24.910 ns** | **0.4014 ns** | **0.3558 ns** | **0.0124** |     **104 B** |
|         Readonly | 1000000 | 20.771 ns | 0.3652 ns | 0.4749 ns | 0.0076 |      64 B |
| Readonly_Checked | 1000000 | 21.709 ns | 0.4473 ns | 0.4972 ns | 0.0076 |      64 B |
|             Span | 1000000 |  1.796 ns | 0.0453 ns | 0.0424 ns |      - |         - |
