namespace TestingCSharp.ВопросыСобеседования;

public static class EnurableTest
{
    public static void Start()
    {
        PlusBefore();
        PlusAfter();
    }

    private static void PlusBefore()
    {
        var ints = new List<int>()
        {
            1, 5, 6
        };
        var calc = 0;
        var q  = ints.Select(q => q = ++q).ToArray();
        Console.WriteLine($"PlusBefore: {string.Join(", ", q)}");
    }

    private static void PlusAfter()
    {
        var ints = new List<int>()
        {
            1, 5, 6
        };
        var calc = 0;
        var q  = ints.Select(q => q = q++).ToArray();
        Console.WriteLine($"PlusAfter: {string.Join(", ", q)}");
    }
}