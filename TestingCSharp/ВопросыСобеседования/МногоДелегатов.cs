namespace TestingCSharp.ВопросыСобеседования;

public class МногоДелегатов
{        
    private delegate decimal delegateExample(decimal a);
    public static void Start()
    {
        decimal a = 2;
        delegateExample w = first;
        Console.WriteLine($"first: {w(a)}");
        w += second;
        Console.WriteLine($"second and first: {w(a)}");
        // Выдает только последнее число. а не все если подписываемся(
        w -= first;
        Console.WriteLine($"second: {w(a)}");
    }

    private static decimal first(decimal a)
    {
        Console.WriteLine($"start first {a}");
        return a * 2;
    }
    private static decimal second(decimal a)
    {
        Console.WriteLine($"start second {a}");
        return a * 3;
    }
}