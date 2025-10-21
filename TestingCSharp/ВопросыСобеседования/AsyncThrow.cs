namespace TestingCSharp.ВопросыСобеседования;

public static class AsyncThrow
{
    public static async Task Start()
    {
        try
        {
            await RunAsync();
            // ThrowAsyncVoid();
            // Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    private static Task RunAsync()
    {
        try
        {
            return new T1().ex();
        }
        catch (Exception e)
        {
            Console.WriteLine("RunAsync");
            throw e;
        }
    }

    private static async void ThrowAsyncVoid()
    {
        Console.WriteLine("ThrowAsyncVoid");
        throw new InvalidOperationException("ThrowAsyncVoid");
    }
}
interface I1
{
    Task ex();
}

class T1: I1
{
    public async Task ex()
    {
        throw new NotImplementedException();
    }
}