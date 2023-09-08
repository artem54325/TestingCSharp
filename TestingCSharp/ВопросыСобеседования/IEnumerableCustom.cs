using System.Collections;

namespace TestingCSharp.ВопросыСобеседования;

public static class IEnumerableCustom
{
    public static void Start()
    {
        var db = new List<string> { "1", "2", "3" };
        var getNumber = GetNumb(db);
        var getAllNumber = GetAllNumb(db);

        var massive = getNumber.ToArray();
        Console.WriteLine($"massive length: {massive.Length}; [0]: {massive[0]}");
        
        var firstNumber = getNumber.OrderByDescending(q => q).First();
        Console.WriteLine($"firstNumber length: {firstNumber};");
        var firstOrderNumber = getNumber.OrderByDescending(q => q).First();
        Console.WriteLine($"firstOrderNumber length: {firstOrderNumber};");
        
        var firstAllNumber = getAllNumber.First();
        Console.WriteLine($"first length: {firstAllNumber};");
        
        var last = getAllNumber.Last();
        Console.WriteLine($"getAllNumber last length: {last};");
        
        
        var singleNumber = getNumber.Single();
        Console.WriteLine($"singleNumber length: {singleNumber};");
        
        //Take
        var takeNumber = getAllNumber.Take(2).ToArray();
        Console.WriteLine($"takeNumber length: {takeNumber.Length};");
        var takeSkipNumber = getAllNumber.Skip(2).Take(1).ToArray();
        Console.WriteLine($"takeNumber length: {takeSkipNumber.Length};");


        var firstOrDefAllNumber = getAllNumber.First();
        Console.WriteLine($"takeNumber length: {firstOrDefAllNumber};");
    }

    private static IEnumerable<string> GetNumb(IEnumerable<string> enumerable)
    {
        using (var l = enumerable.GetEnumerator())
        {
            l.MoveNext();
            Console.WriteLine($"{nameof(GetNumb)} yield return");
            yield return l.Current;
            l.MoveNext();
            Console.WriteLine($"{nameof(GetNumb)} yield break");
            yield break;
            l.MoveNext();
            yield return l.Current;
        }

        yield return "GOVNOOO";
    }

    private static IEnumerable<string> GetAllNumb(IEnumerable<string> enumerable)
    {
        using (var l = enumerable.GetEnumerator())
        {
            while (l.MoveNext())
            {
                Console.WriteLine($"{nameof(GetAllNumb)} yield return");
                yield return l.Current;
            }
        }

        Console.WriteLine($"{nameof(GetAllNumb)} yield return Govno");
        yield return "GOVNOOO";
    }
}