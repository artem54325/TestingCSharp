namespace TestingCSharp.ВопросыСобеседования;

public static class UsingTest
{
    public static void Start()
    {
        using (var usingExample = new UsingExampleThrowConstructor())
        {
            Console.WriteLine("start body");
        }
        Console.WriteLine("finish method");
    }
    private class UsingExampleThrowConstructor : IDisposable
    {
        public UsingExampleThrowConstructor()
        {
            Console.WriteLine("Start constructor");
            throw new Exception("Test");
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }
    }
}