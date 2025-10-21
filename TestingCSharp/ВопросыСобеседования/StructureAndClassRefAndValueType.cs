namespace TestingCSharp.ВопросыСобеседования;

public class StructureAndClassRefAndValueType
{
    public static void Run()
    {
        var val1 = new ValueTypeAndRef(0, "t");
        var val2 = val1.setV(0);
        // var val1ref2 = val1.setR("10");
        // var val2ref3 = val2.setR("20");
        
        Console.WriteLine(val1.v);
        Console.WriteLine(val2.v);
        
        
        Console.WriteLine(val1.ToString());
        Console.WriteLine(val2.ToString());
        // Console.WriteLine(val1ref2.ToString());
        // Console.WriteLine(val2ref3.ToString());
        // Console.WriteLine(ReferenceEquals(val1, val2));
        // Console.WriteLine(ReferenceEquals(val1, val1ref2));
        // Console.WriteLine(ReferenceEquals(val2, val1ref2));
        // Console.WriteLine(ReferenceEquals(val2, val2ref3));
        
        // var v1 =  new ValueType(1);
        // var v2 = v1.setV(20);
        // Console.WriteLine(v1);
        // Console.WriteLine(v2);
    }
}

struct ValueType
{
    public ValueType(int i)
    {
        v = i;
    }

    public int v { get; set; }
    public ValueType setV(int v)
    {
        v++;
        return this;
    }
}

struct ValueTypeAndRef
{
    public ValueTypeAndRef(int v, string r)
    {
        this.v = v;
        // this.r = new ReferenceType(r);
    }

    public int v;

    public ValueTypeAndRef setV(int v)
    {
        this.v++;
        return this;
    }
    public ValueTypeAndRef setR(string v)
    {
        // r.s = v;
        return this;
    }

    // public ReferenceType r { get; set; }
}

class ReferenceType
{
    public ReferenceType(string s)
    {
        this.s = s;
    }
    public string s { get; set; }
}