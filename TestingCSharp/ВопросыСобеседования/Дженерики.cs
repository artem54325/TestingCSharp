namespace TestingCSharp.ВопросыСобеседования;

public class Дженерики
{
    public static void Start()
    {
        var gg1 = new Gener<string>();
        var gg11 = new Gener<string>();
        var gg12 = new Gener<Stream>();
        var gg2 = new Gener<int>();
        var gg3 = new Gener<short>();
        gg1.Add();
        gg11.Add(); 
        gg12.Add();
        gg2.Add();
        gg3.Add();
        Console.WriteLine($"gg1: {gg1.GetCount()}; gg11: {gg11.GetCount()}; gg12: {gg12.GetCount()}; gg2: {gg2.GetCount()}; gg3: {gg3.GetCount()}");
    }
    private class Gener<T>
    {
        public static int Count = 0;

        public int GetCount()
        {
            return Count;
        }

        public void Add()
        {
            Count++;
        }
    }
}