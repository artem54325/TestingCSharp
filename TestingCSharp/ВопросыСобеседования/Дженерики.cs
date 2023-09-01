namespace TestingCSharp.ВопросыСобеседования;

public class Дженерики
{
    public void Start()
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
        Console.WriteLine($"gg1: {gg1.Count}; gg11: {gg11.Count}; gg12: {gg12.Count}; gg2: {gg2.Count}; gg3: {gg3.Count}");
    }
    private class Gener<T>
    {
        public int Count = 0;

        public void Add()
        {
            Count++;
        }
    }
}