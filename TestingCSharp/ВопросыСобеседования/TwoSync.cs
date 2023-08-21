namespace TestingCSharp.ВопросыСобеседования;

public class TwoSync
{
    private static Object syncObject = new Object();
    private static void Write()
    {
        lock (syncObject)
        {
            Console.WriteLine("test");
        }
    }
    public static void Init()
    {
        lock (syncObject)
        {
            Write();
        }
    }
}