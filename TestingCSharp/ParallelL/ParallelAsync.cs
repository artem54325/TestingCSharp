using System.Collections.Concurrent;
using System.Diagnostics;

namespace TestingCSharp.ParallelL;

public class ParallelAsync
{
    public static async Task Main()
    {
        var timer = new Stopwatch();
        timer.Start();

        var myData = new ConcurrentBag<int>();

        await Task.Run(() =>
        {
            Parallel.Invoke(
                () => { myData.Add(Helper.HeavyComputation("A")); },
                () => { myData.Add(Helper.HeavyComputation("B")); },
                () => { myData.Add(Helper.HeavyComputation("C")); },
                () => { myData.Add(Helper.HeavyComputation("D")); },
                () => { myData.Add(Helper.HeavyComputation("E")); });
        });
        timer.Stop();
        Console.WriteLine("All: " + timer.ElapsedMilliseconds);

        Console.WriteLine(string.Join(",", myData));
    }
}