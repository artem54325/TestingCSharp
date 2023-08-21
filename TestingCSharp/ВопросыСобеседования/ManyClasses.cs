namespace TestingCSharp.ВопросыСобеседования;

public class ManyClasses
{
    public static void Init()
    {
        var c = new C();
        A a = c;
        
        a.Print2();
        a.Print1();
        c.Print2();
    }
}

public class A
{
    public virtual void Print1()
    {
        Console.Write("A");
    }
    public void Print2()
    {
        Console.Write("A");
    }
}
public class B: A
{
    public override void Print1()
    {
        Console.Write("B");
    }
}
public class C : B
{
    new public void Print2()
    {
        Console.Write("C");
    }
}