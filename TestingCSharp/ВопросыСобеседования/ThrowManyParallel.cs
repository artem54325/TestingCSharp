namespace TestingCSharp.ВопросыСобеседования;

public static class ThrowManyParallel
{
    public static void Start()
    {
        CancellationTokenSource mainCancellationTokenSource = new CancellationTokenSource();
        try
        {
            Task task1 = new Task(() =>
            {
                try
                {
                    throw new Exception("Exception message");
                }
                catch (Exception ex)
                {
                    throw;
                    // mainCancellationTokenSource.Cancel();
                }

            }, mainCancellationTokenSource.Token);

            Task task2 = new Task(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(3));
                Console.WriteLine("Task is running");

            }, mainCancellationTokenSource.Token);

            task1.Start();
            task2.Start();

            Task.WaitAll(new[] { task1, task2}, 
                6000, // 6 seconds
                mainCancellationTokenSource.Token
            );
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}