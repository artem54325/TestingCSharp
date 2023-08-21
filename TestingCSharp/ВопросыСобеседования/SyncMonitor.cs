namespace TestingCSharp.ВопросыСобеседования;

public class SyncMonitor
{
    public static void Init()
    {
        object sync = new object();
        var thread = new Thread(()=>
        {
            try
            {
                Console.WriteLine("start work");
                Work();
                Console.WriteLine("finish work");
            }
            finally
            {
                lock (sync)
                {
                    Console.WriteLine("start finally");
                    Monitor.Pulse(sync);
                }
            }
        });
        thread.Start();
        lock (sync)
        {
            Console.WriteLine("start Wait");
            Monitor.Wait(sync);
            Console.WriteLine("finish Wait");
        }
        Console.WriteLine("test");
    }
    private static void Work()
    {
        Thread.Sleep(1000);
    }
}