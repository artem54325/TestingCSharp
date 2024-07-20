using BenchmarkDotNet.Attributes;

namespace TestingCSharp.Span;

public class SpanContains
{
    private const string TestText = "some big value for test";
    private const string TestStartWithStr = "some";
    private static readonly char[] TestStartWithChars = new[]{
        's', 'o', 'm', 'e'
    };

    [Benchmark]// 1
    public void StartWith()
    {
        var result = false;
        if (TestText.StartsWith(TestStartWithStr))
        {
            result = true;
        }
    }

    [Benchmark] // 2
    public void Slice03()
    {
        var result = false;
        var span = TestText.AsSpan();
        var startSpan = new Span<char>(TestStartWithChars);
        if (span.Slice(0, 4).Equals(startSpan, StringComparison.Ordinal))
        {
            result = true;
        }
    }

    [Benchmark] // 3
    public void Slice03EqualsString()
    {
        var result = false;
        var span = TestText.AsSpan();
        if (span.Slice(0, 4).Equals(TestStartWithStr, 
                StringComparison.CurrentCulture))
        {
            result = true;
        }
    }

    [Benchmark] // 4
    public void Slice03EqualsChars()
    {
        var result = false;
        var span = TestText.AsSpan();
        if (span.Slice(0, 4).Equals(TestStartWithChars, 
                StringComparison.CurrentCulture))
        {
            result = true;
        }
    }
}