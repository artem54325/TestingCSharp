using BenchmarkDotNet.Attributes;

namespace TestingCSharp.Span;

[MemoryDiagnoser]
public class SpanSum
{
    [Params(100, 10000, 1000000)] 
    public int N = 100;
    private int[] _data;

    public SpanSum()
    {
        _data = new int[N];
        var maxValue = N * 100;
        for (int i = 0; i < N; i++)
        {
            _data[i] = new Random(42).Next(maxValue);
        }
    }

    [Benchmark]
    public int Linq()
    {
        var s = _data.Sum();
        return s;
    }

    [Benchmark]
    public int Span()
    {
        int sum = 0;
        foreach (var d in _data.AsSpan())
        {
            sum += d;
        }
        return sum;
    }

    [Benchmark]
    public int Span_Checked()
    {
        int sum = 0;
        foreach (var d in _data.AsSpan())
        {
            checked
            {
                sum += d;
            }
        }

        return sum;
    }
}