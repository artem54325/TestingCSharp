using BenchmarkDotNet.Attributes;

namespace TestingCSharp.Infrastructure.StructureClass;

[MemoryDiagnoser]
public class StructureTesting
{
    // [Params(100, 100000)] public long n = 100_000;
    [Params(100)] public long n = 100_000;

    private StructureRef[] StructureRefs;
    private ClassRef[] ClassRefs;
    private string[] Primitive;

    [GlobalSetup]
    public void GlobalSetup()
    {
        StructureRefs = new StructureRef[n];
        ClassRefs = new ClassRef[n];
        Primitive = new string[n];
        for (int i = 0; i < n; i++)
        {
            var rnd = Guid.NewGuid().ToString();
            StructureRefs[i] = new StructureRef
            {
                value = rnd
            };
            ClassRefs[i] = new ClassRef
            {
                value = rnd
            };
            Primitive[i] = rnd;
        }
    }

    [Benchmark]
    public string Add_Structure()
    {
        var list = new List<StructureRef>();
        for (int i = 0; i < n; i++)
        {
            list.Add(new StructureRef
            {
                value = "random value"
            });
        }

        return list.Count.ToString();
    }

    [Benchmark]
    public string Add_Class()
    {
        var list = new List<ClassRef>();
        for (int i = 0; i < n; i++)
        {
            list.Add(new ClassRef
            {
                value = "random value"
            });
        }

        return list.Count.ToString();
    }

    [Benchmark]
    public string Add_Primitive()
    {
        var list = new List<string>();
        for (int i = 0; i < n; i++)
        {
            list.Add("random value");
        }

        return list.Count.ToString();
    }

    [Benchmark]
    public void Get_Structure()
    {
        var getFirst = StructureRefs[0];
        var getLast = StructureRefs[n - 1];
        var getMiddle = StructureRefs[n / 2];
    }

    [Benchmark]
    public void Get_Class()
    {
        var getFirst = ClassRefs[0];
        var getLast = ClassRefs[n - 1];
        var getMiddle = ClassRefs[n / 2];
    }

    [Benchmark]
    public void Get_Primitive()
    {
        var getFirst = Primitive[0];
        var getLast = Primitive[n - 1];
        var getMiddle = Primitive[n / 2];
    }

    [Benchmark]
    public void Get_Where_Structure()
    {
        var whereLine = StructureRefs.Where(q => q.value.Contains("-")).ToArray();
        var whereSymbolA = StructureRefs.Where(q => q.value.Contains("a")).ToArray();
        var whereSymbolB = StructureRefs.Where(q => q.value.Contains("b")).ToArray();
    }

    [Benchmark]
    public void Get_Where_Classes()
    {
        var whereLine = ClassRefs.Where(q => q.value.Contains("-")).ToArray();
        var whereSymbolA = ClassRefs.Where(q => q.value.Contains("a")).ToArray();
        var whereSymbolB = ClassRefs.Where(q => q.value.Contains("b")).ToArray();
    }

    [Benchmark]
    public void Get_Where_Primitive()
    {
        var whereLine = Primitive.Where(q => q.Contains("-")).ToArray();
        var whereSymbolA = Primitive.Where(q => q.Contains("a")).ToArray();
        var whereSymbolB = Primitive.Where(q => q.Contains("b")).ToArray();
    }

    // [Benchmark]
    // public void Remove_Primitive()
    // {
    //     StructureRefs.
    // }
}

public struct StructureRef
{
    public string value { get; set; }
}

public class ClassRef
{
    public string value { get; set; }
}