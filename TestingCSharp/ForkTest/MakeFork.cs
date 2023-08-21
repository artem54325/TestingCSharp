using System.Diagnostics;

namespace TestingCSharp.ForkTest;

public class MakeFork
{
    void MakeFork2()
    {
        // Для уверенности что все склонировалось мы делаем локальные переменные:
        // В новом потоке их значения обязаны быть такими же как и в родительском
        var sameLocalVariable = 123;
        var sync = new object();

        // Замеряем время
        var stopwatch = Stopwatch.StartNew();

        // Клонируем поток
        // var forked = Fork.CloneThread();
        //
        // // С этой точки код исполняется двумя потоками. 
        // // forked = true для дочернего потока, false для родительского
        // lock(sync)
        // {
        //     Console.WriteLine("in {0} thread: {1}, local value: {2}, time to enter = {3} ms",
        //         forked ? "forked" : "parent",
        //         Thread.CurrentThread.ManagedThreadId,
        //         sameLocalVariable,
        //         stopwatch.ElapsedMilliseconds);
        // }

        // При выходе из метода родительский вернет управления в метод,
        // который вызвал MakeFork(), т.е. продолжит работу как ни в чем ни бывало,
        // а дочерний завершит исполнение.
    }
}