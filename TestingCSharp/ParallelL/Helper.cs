using System.Diagnostics;

namespace TestingCSharp.ParallelL;

public class Helper
{
    public static int HeavyComputation(string name)
    {
        Console.WriteLine("Start: " + name);
        var timer = new Stopwatch();
        timer.Start();
        var result = 0;
        for (var i = 0; i < 10_000_000; i++)
        {
            var a = ((i + 1_500) / (i + 30)) * (i + 10);
            result += (a % 10) - 120;
        }
        timer.Stop();
        Console.WriteLine("End: "+ name + ' ' + timer.ElapsedMilliseconds);
        return result;
    }
}