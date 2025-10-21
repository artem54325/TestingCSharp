namespace TestingCSharp.ВопросыСобеседования;

public class Замыкание
{
    public void Run()
    {
        var actions = new List<Action>();
        for (int i = 0; i < 10; i++)
        {
            // var l = i;
            actions.Add(() => Console.WriteLine(i));
        }

        foreach(var a in actions)
        {
            a();
        }
    }
    public static void Start()
    {
        int counter = 0;
        var data = Enumerable.Range(0, 5)
            .Select(x =>
            {
                counter++;
                return x;
            });
        List<int> list = [..data, ..data];
        Console.WriteLine(data.Count());
        Console.WriteLine(list.Count());
        Console.WriteLine(counter);
    }
}