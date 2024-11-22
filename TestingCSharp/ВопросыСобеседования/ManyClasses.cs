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
        Console.WriteLine();
        Console.WriteLine("вариант-2");
        
        new ManyClasses().Run();
    }

    public void Run()
    {
        // Base w = new Child();
        var w = new Child();
        w.method1();
        w.method2();
        Run2(w);
    }

    public void Run2(Base w)
    {
        w.method1();
        w.method2();
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
    public new void Print2()
    {
        Console.Write("C");
    }
}

public abstract class Base
{
    public virtual void method1()
    {
        Console.WriteLine("Base.method1");
    }
    public void method2()
    {
        Console.WriteLine("Base.method2");
    }
}
public class Child : Base
{
    public override void method1()
    {
        Console.WriteLine("Child.method1");
    }
    public void method2()
    {
        Console.WriteLine("Child.method2");
    }
}