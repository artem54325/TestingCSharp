using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using BenchmarkDotNet.Attributes;

namespace TestingCSharp.Span;

[MemoryDiagnoser]
public class SpanListRegexpNumber
{
    [Params(100, 10000, 1000000)] public int N;
    private List<string> _data;
    
    private static Random random = new();
    private readonly Regex _regex= new (@"туп(\w*)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
    public static string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public SpanListRegexpNumber()
    {
        _data = new List<string>(N);
        var maxValue = 300;
        for (int i = 0; i < N; i++)
        {
            _data[i] = RandomString(maxValue);
        }
    }

    [Benchmark]
    public int Linq()
    {
        var s = _data.Count(a => _regex.IsMatch(a));
        return s;
    }

    [Benchmark]
    public int Readonly()
    {
        int sum = 0;
        foreach (var d in _data.AsReadOnly())
        {
            if (_regex.IsMatch(d))
                sum += 1;
        }
        return sum;
    }

    [Benchmark]
    public int Readonly_Checked()
    {
        int sum = 0;
        foreach (var d in _data.AsReadOnly())
        {
            checked
            {
                if (_regex.IsMatch(d))
                    sum += 1;
            }
        }

        return sum;
    }
    
    [Benchmark]
    public int Span()
    {
        int sum = 0;
        foreach (var d in CollectionsMarshal.AsSpan(_data))
        {
            if (_regex.IsMatch(d))
                sum += 1;
        }
        return sum;
    }
    
    [Benchmark]
    public int Span_From_ToArray()
    {
        int sum = 0;
        foreach (var d in _data.ToArray().AsSpan())
        {
            if (_regex.IsMatch(d))
                sum += 1;
        }
        return sum;
    }
}