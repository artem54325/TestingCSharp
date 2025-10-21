namespace TestingCSharp.ParallelL;

public class Synchronization
{
    public static async void Main()
    {
        var finalResult = 0;

        await Task.Run(() =>
        {
            Parallel.For((long)0, 20, i => 
            { 
                finalResult += Helper.HeavyComputation(i.ToString()); 
            });
        });
        
        var finalResult2 = 0;
        var syncRoot2 = new object();

        await Task.Run(() =>
        {
            Parallel.For(0, 20, i =>
            {
                var localResult = Helper.HeavyComputation(i.ToString());
                lock (syncRoot2)
                {
                    //one thread at the same time
                    finalResult2 += localResult;
                }
            });
        });
    }
}