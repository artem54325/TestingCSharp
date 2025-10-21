namespace TestingCSharp.ВопросыСобеседования;

public class StructurePlusPlus
{
    public static void Run()
    {
        var d1 = new D();
        var d2 = d1.Inc();
        object d3 = d2.Inc();
        object d4 = ((D)d3).Inc();
        
        Console.WriteLine(ReferenceEquals(d2, d3));
        
        Console.WriteLine($"{d1.x} {d2.x} {((D)d3).x} {((D)d4).x}");
        // 1 2 2 3
    }
}

struct D
{
    public int x;
    public D()
    {
        x = 0;
    }
    public D Inc()
    {
        x++;
        return this;
    }
}