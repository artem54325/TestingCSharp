namespace TestingCSharp.AsyncAndMultipleThread;

public class TaskFactory
{
    public static void Start()
    {
        Console.WriteLine("Starting program");

        // Log("this information need to be logged");
        var taskFactory = Task.Factory.StartNew(() => Log("this information need to be logged, Task.Factory"));
        var taskRun = Task.Run(() => Log("test Task,Run"));
        var task2 = new Task(() => Log("test Task, task"));
        task2.Start();
        FileInfo fi = new FileInfo("AsyncAndMultipleThread/test.txt");
        byte[] data = new byte[fi.Length];
        FileStream fs = new FileStream("AsyncAndMultipleThread/test.txt", FileMode.Open, FileAccess.Read,
            FileShare.Read, data.Length, true);
        // We still pass null for the last parameter because
        // the state variable is visible to the continuation delegate.
        Task<int> task = Task<int>.Factory.FromAsync(
            fs.BeginRead, fs.EndRead, data, 0, data.Length, null);
        int result = task.Result;
        Console.WriteLine(result);
        // Task.WaitAll(taskFactory, taskRun, task2);   // Ожидаем всех потоков
        Task.WaitAll(taskFactory, taskRun, task2);

        Console.WriteLine("Press any key to exit");
        // Console.ReadLine();
    }

    private static void Log(string message)
    {
        //Simulate long running method
        Thread.Sleep(3000);
        //Log to file or database
        Console.WriteLine($"Logging done: {message}");
    }
}