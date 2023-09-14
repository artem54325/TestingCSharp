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
// RefValueTye.Start();

return;

// delegate void qwe(int x, int y);



// Predicate<double> predicate = (str) = & gt;  
// {  
//     double retNum;  
//     bool isNum = Double.TryParse(Convert.ToString(str), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);  
//     return isNum;  
// };  
// bool found = predicate("12232");  

// public sealed class Program3 : Program2
// {
//     internal override string Test(string w)
//     {
//         return null;
//     }
// }