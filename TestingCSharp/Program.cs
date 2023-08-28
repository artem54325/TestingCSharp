﻿// // Создаем параметры для x и Id
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

using BenchmarkDotNet.Running;
using TestingCSharp.Infrastructure;
using TestingCSharp.Infrastructure.StructureClass;
using TestingCSharp.Span;
using TestingCSharp.StringConcatBuilder;


// BenchmarkRunner.Run<SpanSum>();
Demo();

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
static async Task<string> DelayAsync()
{
    Console.WriteLine("start");
    await Task.Delay(1000);
    Console.WriteLine("finish1");
    throw new Exception("Example");
    return "Example";
}
static void Demo()
{
    var delayTask = DelayAsync();
    Console.WriteLine("start1");
    // delayTask.Wait();
    // {delayTask.Result} // Выдает разные ошибки   AggregateException: One or more errors occurred.
    // delayTask.GetAwaiter().GetResult()// Выдает саму ошибку
    Console.WriteLine($"finish2  {delayTask.Result}");
}