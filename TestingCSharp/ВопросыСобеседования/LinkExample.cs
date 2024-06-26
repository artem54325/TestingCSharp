namespace TestingCSharp.ВопросыСобеседования;

public class LinkExample
{
    public static void Main()
    {
        var list = new List<int>();
        int i = 10;
        var query = list.Where(x => x == i).Where(x => x < 20);

        i = 15;
        list.Add(10);
        list.Add(15);
        list.Add(20);
        Console.WriteLine(query.Count());
        Console.WriteLine(query.First());
    }
}