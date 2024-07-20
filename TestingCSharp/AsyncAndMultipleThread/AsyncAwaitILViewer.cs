namespace TestingCSharp.Span;

public class AsyncAwaitILViewer
{
    public void Test1()
    {
        Test2().GetAwaiter().GetResult();
    }
    public async Task Test2()
    {
        // Test1();
        // await Task.Delay(100);
        // Test1();
        // await Task.Delay(100);
        // Test1();
        await Task.Delay(100);
        
        int delay = int.Parse(Console.ReadLine());
        await Task.Delay(delay);
        
        var _fileContent = await File.ReadAllTextAsync("file1");
        
        await Task.Delay(delay);
        int delay2 = int.Parse(Console.ReadLine());
        await Task.Delay(100);
    }
}