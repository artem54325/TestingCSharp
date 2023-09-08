using System.Collections;

namespace TestingCSharp.ВопросыСобеседования;

public static class IEnumerableCustom
{
    public static void Start()
    {
        var get = GetNumb(new List<string>{"1", "2", "3"});
        var massive = get.ToArray();
        Console.WriteLine($"length: {massive.Length}; [0]: {massive[0]}");
    }

    private static IEnumerable<string> GetNumb(IEnumerable<string> enumerable)
    {
        using (var l = enumerable.GetEnumerator())
        {
            l.MoveNext();
            yield return l.Current;
            l.MoveNext();
            yield break;
            l.MoveNext();
            yield return l.Current;
        }
        yield return "GOVNOOO";
    }
}