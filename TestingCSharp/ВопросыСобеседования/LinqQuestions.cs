namespace TestingCSharp.ВопросыСобеседования;

public class LinqQuestions
{
    public void Test1()
    {
        var filters = new List<Func<int, bool>>();
        for (int i = 0; i < 3; i++) {
            filters.Add(x => x > i);
        }

        var numbers = new[] { 1, 2, 3, 4, 5 };
        var result = numbers
            .Where(filters[0]);
    }
    public void Test2()
    {
        var tasks = new List<Task>();
        for (int i = 0; i < 5; i++) {
            tasks.Add(Task.Run(() => Console.WriteLine(i)));
        }
        Task.WaitAll(tasks.ToArray());
    }
    public void Test3()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        foreach (var item in list) {
            if (item == 3) {
                list.Add(6); // Что произойдет?
            }
            Console.WriteLine(item);
        }
    }
}