namespace TestingCSharp.AsyncAndMultipleThread;

public class AsyncDemo
{
    public static async Task<string> DelayAsync()
    {
        Console.WriteLine("start");
        await Task.Delay(1000);
        Console.WriteLine("finish1");
        throw new Exception("Example");
        return "Example";
    }

    public static void Demo()
    {
        var delayTask = DelayAsync();
        Console.WriteLine("start1");
        // delayTask.Wait();
        var res = delayTask.Result; // Выдает разные ошибки   AggregateException: One or more errors occurred.
        res = delayTask.GetAwaiter().GetResult(); // Выдает саму ошибку
        // Console.WriteLine($"finish2  {delayTask.Result}");
    }
}