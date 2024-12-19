namespace TestingCSharp.ВопросыСобеседования;

public class TestingChecked
{
    public static void Main()
    {
        int x = int.MaxValue - 3;
        int someval = 100;

        // вариант 1
        x = Method1(x, someval);
        
        // вариант 2 - возникает Exception
        x = Method1(x, someval);
        Console.WriteLine($"result: {x}");
    }

    private static int Method1(int x, int someval)
    {
        x += someval;
        return x;
    }

    private static int Method2(int x, int someval)
    {
        try
        {
            checked
            {
                x += someval;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine($"OverflowException");
        }

        return x;
    }
}