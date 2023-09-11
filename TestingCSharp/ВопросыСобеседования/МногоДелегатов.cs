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
        Console.WriteLine($"send and first: {w(a)}");
    }

    public static decimal first(decimal a)
    {
        return a * 2;
    }
    public static decimal second(decimal a)
    {
        return a * 3;
    }
}