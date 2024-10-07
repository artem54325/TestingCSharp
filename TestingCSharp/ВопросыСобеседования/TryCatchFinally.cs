namespace TestingCSharp.ВопросыСобеседования;

public class TryCatchFinally
{
    public static void Start()
    {
        Run();
    }

    public static int Run()
    {
        try
        {
            Console.WriteLine("try");
            return 1;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception");
            return 2;
        }
        finally
        {
            Console.WriteLine("Finaly");
        }
    }
}