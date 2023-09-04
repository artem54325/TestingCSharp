namespace TestingCSharp.ВопросыСобеседования;

public class ThreadTest
{
    static bool done; // Static fields are shared between all threads

    public static void Start()
    {
        var t = new ThreadTest();
        new Thread(t.Go).Start();
        t.Go();
    }

    void Go()
    {
        if (!done)
        {
            done = true;
            Console.WriteLine("Done");
        }
    }
}