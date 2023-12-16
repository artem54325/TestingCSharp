// // Создаем параметры для x и Id
// var xParameter = Expression.Parameter(typeof(Directory), "x");
// var idProperty = Expression.Property(xParameter, "Id");
//
// // Создаем константу для списка ids
// var idsConstant = Expression.Constant(new List<int> { 1, 2, 3 }, typeof(List<int>));
//
// // Создаем вызов метода Contains для списка ids
// var containsMethod = typeof(List<int>).GetMethod("Contains", new[] { typeof(int) });
// var containsCall = Expression.Call(idsConstant, containsMethod!, idProperty);
//
// // Создаем лямбда-выражение для x => ids.Contains(x.Id)
// var lambda = Expression.Lambda<Func<Directory, bool>>(containsCall, xParameter);
//
// var actualFilteredList = _directories.All.AsQueryable().Where(lambda).ToList();

using System.Text;
using BenchmarkDotNet.Running;
using TestingCSharp.AsyncAndMultipleThread;
using TestingCSharp.Infrastructure;
using TestingCSharp.Infrastructure.StructureClass;
using TestingCSharp.Span;
using TestingCSharp.StringConcatBuilder;
using TestingCSharp.ВопросыСобеседования;
using TestingCSharp.ПриведениеТипов;

var t = typeof(AsyncDemo).Assembly;
// ПриведениеТипов.Start();
// BenchmarkRunner.Run<SpanSum>();
// AsyncDemo.Demo();

// static async Task Test()
// {
//     Thread.Sleep(1000);
//     Console.WriteLine("work");
//     await Task.Delay(1000);
// }
//
// static void Demo()
// {
//     var child = Test();
//     Console.WriteLine("started");
//     child.Wait();
//     Console.WriteLine("finished");
// }
// Дженерики.Start();
// EnurableTest.Start();
// Интерфейсы.Start();
// StringInterpretator.Start();
// UsingTest.Start();
// TryCatchTest.Start();
// GsCollection.Start();
// VolaliteTest.Start();
// ThreadTest.Start();
// IEnumerableCustom.Start();
// ПередачаПоСсылке.Start();
// МногоДелегатов.Start();
// AsyncThrow.Start();
// EqualsTest.Start();
// ByteDictionary.Start();
// var k1 = new KeyValuePair<int, int>(10, 29);
// var k2 = new KeyValuePair<int, int>(10, 31);
// Console.WriteLine("k1 - {0}, k2 - {1}", k1.GetHashCode(), k2.GetHashCode());
//
// var v1 = new KeyValuePair<int, string>(10, "abc");
// var v2 = new KeyValuePair<int, string>(10, "def");
// Console.WriteLine("v1 - {0}, v2 - {1}", v1.GetHashCode(), v2.GetHashCode());

Foo test = new Bar();
Console.WriteLine (test.DoSomethingNew());
Console.WriteLine (test.DoSomethingVirtual());
Console.WriteLine (test.DoSomethingUsually());

// Console.WriteLine(Exx.GetX());
return;

public class Foo
{
    public string DoSomethingNew() { return "Foo New"; }
    public virtual string DoSomethingVirtual() { return "Foo Virtual"; }
    public string DoSomethingUsually() { return "Foo Usually"; }
}
public class Bar : Foo
{
    public new string DoSomethingNew() { return "Bar new"; }
    public override string DoSomethingVirtual() { return "Bar Virtual"; }
    public string DoSomethingUsually() { return "Bar Usually"; }
}

public class Exx
{
    public static int GetX()
    {
        try
        {
            throw new Exception("Example");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return 1;
        }
        finally
        {
            Console.WriteLine("Exx");
        }
    }
}

public class Program2 // sealed class - нельзя наследоваться от него
{
    internal virtual string Test(string q)
    {
        return null;
    }
}

public sealed class Program3 : Program2
{
    internal override string Test(string w)
    {
        return null;
    }
}