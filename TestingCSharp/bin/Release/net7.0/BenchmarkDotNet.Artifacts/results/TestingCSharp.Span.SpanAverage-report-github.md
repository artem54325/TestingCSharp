``` ini

BenchmarkDotNet=v0.13.5, OS=macOS Ventura 13.4.1 (22F82) [Darwin 22.5.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
| Method |     Mean |     Error |    StdDev |
|------- |---------:|----------:|----------:|
|   Linq |       NA |        NA |        NA |
|   Span | 3.292 μs | 0.0657 μs | 0.1201 μs |

Benchmarks with issues:
  SpanAverage.Linq: DefaultJob
