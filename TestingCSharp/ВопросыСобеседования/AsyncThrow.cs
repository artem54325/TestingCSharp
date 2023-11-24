namespace TestingCSharp.ВопросыСобеседования;

public static class AsyncThrow
{
    public static void Start()
    {
        try
        {
            ThrowAsyncVoid();
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    private static async void ThrowAsyncVoid()
    {
        Console.WriteLine("ThrowAsyncVoid");
        throw new InvalidOperationException("ThrowAsyncVoid");
    }
}