// using System.Diagnostics;
//
// namespace TestingCSharp.ParallelL;
//
// public class NotParallel
// {
//     public static void Main()
//     {
//         var timer = new Stopwatch(); 
//         timer.Start();
//         Helper.HeavyComputation("A");
//         Helper.HeavyComputation("B");
//         Helper.HeavyComputation("C");
//         Helper.HeavyComputation("D");
//         Helper.HeavyComputation("E");
//         timer.Stop();
//         Console.WriteLine("All: " + timer.ElapsedMilliseconds);
//     }
// }