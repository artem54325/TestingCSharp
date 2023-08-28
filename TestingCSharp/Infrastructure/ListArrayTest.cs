using BenchmarkDotNet.Attributes;

namespace TestingCSharp.Infrastructure;

public struct StructureInt
{
    public int Value { get; set; }
}
[MemoryDiagnoser]
public class ListArrayTest
{
    // [Params(100, 100000)] public long n = 100_000;
    [Params(100)] public long n = 100_000;
    string[] valsArray;
    List<string> valsList = new();
    LinkedList<string> valsLinkedList = new();
    
    [GlobalSetup]
    public void GlobalSetup()
    {
        valsArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            valsArray[i] = Guid.NewGuid().ToString();
            valsList.Add(valsArray[i]);
            valsLinkedList.AddLast(valsArray[i]);
        }
    }
    
    [Benchmark]
    public void ListInt()
    {
        List<int> li = new List<int>();

        for (int i = 0; i < n; i++)
        {
            li.Add(i);
        }
    }
    [Benchmark]
    public void LinkedListFirst()
    {
        var li = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            li.AddFirst(i);
        }
    }
    [Benchmark]
    public void LinkedListLast()
    {
        var li = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            li.AddLast(i);
        }
    }
    
    [Benchmark]
    public void ListToArray()
    {
        for (int i = 0; i < n; i++)
        {
            var strings = valsList.ToArray();
        }
    }
    
    [Benchmark]
    public void LinkedToArray()
    {
        for (int i = 0; i < n; i++)
        {
            var strings = valsLinkedList.ToArray();
        }
    }
    
    [Benchmark]
    public void ArrayToList()
    {
        for (int i = 0; i < n; i++)
        {
            var strings = valsArray.ToList();
        }
    }
    
    [Benchmark]
    public void ListWhere()
    {
        for (int i = 0; i < n; i++)
        {
            var strings = valsList.Where(q=>q == "-").ToArray();
        }
    }
    
    [Benchmark]
    public void LinkedWhere()
    {
        for (int i = 0; i < n; i++)
        {
            var strings = valsLinkedList.Where(q=>q == "-").ToArray();
        }
    }
    
    [Benchmark]
    public void ListStructure()
    {
        List<StructureInt> li = new List<StructureInt>();

        for (int i = 0; i < n; i++)
        {
            li.Add(new StructureInt
            {
                Value = i
            });
        }
    }

    [Benchmark]
    //List object
    public void ListObject()
    {
        List<object> li = new List<object>();

        for (int i = 0; i < n; i++)
        {
            li.Add(i);
        }
    }

    //List long
    [Benchmark]
    public void ListLong()
    {
        List<long> li = new List<long>();

        for (int i = 0; i < n; i++)
        {
            li.Add(i);
        }
    }

    //List ulong
    [Benchmark]
    public void ListUlong()
    {
        List<ulong> li = new List<ulong>();
        ulong N = ulong.Parse($"{n}");

        for (ulong i = 0; i < N; i++)
        {
            li.Add(i);
        }
    }

    //Array int
    [Benchmark]
    public void ArrayInt()
    {
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            a[i] = i;
        }
    }
    
    [Benchmark]
    public void ArrayWhere()
    {
        for (int i = 0; i < n; i++)
        {
            var strings = valsArray.Where(q=>q == "-").ToArray();
        }
    }
    
    [Benchmark]
    public void ArrayStructure()
    {
        StructureInt[] li = new StructureInt[n];

        for (int i = 0; i < n; i++)
        {
            li[i] = new StructureInt
            {
                Value = i
            };
        }
    }
    //Array object
    [Benchmark]
    public void ArrayObject()
    {
        object[] a = new object[n];

        for (int i = 0; i < n; i++)
        {
            a[i] = i;
        }
    }

    //Array long
    [Benchmark]
    public void ArrayLong()
    {
        long[] a = new long[n];

        for (long i = 0; i < n; i++)
        {
            a[i] = i;
        }
    }

    //Array ulong
    [Benchmark]
    public void ArrayUlong()
    {
        ulong[] a = new ulong[n];
        ulong N = ulong.Parse($"{n}");

        for (ulong i = 0; i < N; i++)
        {
            a[i] = i;
        }
    }
}