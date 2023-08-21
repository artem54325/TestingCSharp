using System.Text;
using BenchmarkDotNet.Attributes;

namespace TestingCSharp.StringConcatBuilder;

[MemoryDiagnoser]
public class TestingConcatBuilder
{
    [Params(100, 100000, 5000000)]
    public long n = 100_000;

    string[] vals;

    [GlobalSetup]
    public void GlobalSetup()
    {
        vals = new string[n];
        for (int i = 0; i < n; i++)
        {
            vals[i] = Guid.NewGuid().ToString();
        }
    }

    [Benchmark]
    public string Concat()
    {
        var concat = string.Concat(vals);
        return concat;
    }


    [Benchmark]
    public string Join()
    {
        var concat = string.Join("", vals);
        return concat;
    }

    [Benchmark]
    public string StringBuilderForeach()
    {
        var builder = new StringBuilder();
        foreach (var val in vals)
        {
            builder.Append(val);
        }

        return builder.ToString();
    }

    [Benchmark]
    public string StringBuilderFor()
    {
        var builder = new StringBuilder();
        for (int i = 0; i < vals.Length; i++)
        {
            builder.Append(vals[i]);
        }

        return builder.ToString();
    }
}