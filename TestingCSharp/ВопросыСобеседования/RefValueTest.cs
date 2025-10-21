namespace TestingCSharp.ВопросыСобеседования;

public class RefValueTest
{
    public static void Run()
    {
        // var a = new BC() { A = 5 };
        // var b = new BC() { A = 8 };
        // a = b;
        // a.A = 3;
        // a = new BC() { A = 10 };
        // Console.WriteLine(b.A);
        
        var wa = new BC() { A = 5 };
        Test(wa);
        Console.WriteLine(wa.A);
        TestRef(ref wa);
        Console.WriteLine(wa.A);

        // object x = 11;
        // object o = x;
        // x = 12;
        // var y = (int)o;
        // Console.WriteLine(y);
    }

    private static void Test(BC a)
    {
        a = new BC()
        {
            A = 10
        };
    }

    private static void TestRef(ref BC a)
    {
        a = new BC()
        {
            A = 10
        };
    }
}

record BC
{
    public int A { get; set; }
}