using System.ComponentModel.DataAnnotations;

namespace TestingCSharp.ВопросыСобеседования;

public class AsyncAwaitThrow
{
    public static void RUNMain()
    {
        RunAsync().GetAwaiter().GetResult();
    }
    public static async Task RunAsync()
    {
        var ww = new AsyncAwaitThrow();
        // await ww.CorrectUsageAsync();
        // await ww.IncorrectUsageAsync();
        await ww.CorrectUsageAsync();
    }
    // Асинхронный метод, который имитирует загрузку данных
    private async Task<string> FetchDataAsync()
    {
        Console.WriteLine("Начало загрузки данных...");
        await Task.Delay(1000); // Имитация долгой операции (например, HTTP-запрос)
        Console.WriteLine("Данные загружены!");
        return "Реальные данные";
    }

// ПРАВИЛЬНЫЙ вызов с await
    private  async Task CorrectUsageAsync()
    {
        Console.WriteLine("=== ПРАВИЛЬНОЕ использование ===");
        string data = await FetchDataAsync(); // Ждем результат
        Console.WriteLine($"Результат: {data}"); // "Реальные данные"
        Console.WriteLine($"Длина данных: {data.Length}"); // 14
    }

// НЕПРАВИЛЬНЫЙ вызов БЕЗ await
    private  async Task IncorrectUsageAsync()
    {
        Console.WriteLine("=== НЕПРАВИЛЬНОЕ использование ===");
        Task<string> dataTask = FetchDataAsync(); // ЗАБЫЛИ AWAIT! Получаем Task<string>, а не string
        Console.WriteLine($"Результат: {dataTask}"); // System.Threading.Tasks.Task`1[System.String]
        Console.WriteLine($"Статус задачи: {dataTask.Status}"); // Running (или WaitingForActivation)
    
        // ОПАСНО: попытка использовать результат как строку
        // Console.WriteLine($"Длина данных: {dataTask.Length}"); // НЕ СКОМПИЛИРУЕТСЯ - у Task нет Length
    
        // Но если бы мы использовали var...
        var dangerousData = FetchDataAsync(); // компилятор выведет тип как Task<string>
        // Console.WriteLine(dangerousData.Length); // Тоже не скомпилируется
    }
// НЕПРАВИЛЬНЫЙ вызов БЕЗ await с throw
    private  async Task IncorrectUsageThrowAsync()
    {
        await Task.CompletedTask;
        throw new ValidationException("Test");
    }
    private async void IncorrectVoidUsageAsync()
    {
        Console.WriteLine("=== НЕПРАВИЛЬНОЕ использование ===");
        Task<string> dataTask = FetchDataAsync(); // ЗАБЫЛИ AWAIT! Получаем Task<string>, а не string
        Console.WriteLine($"Результат: {dataTask}"); // System.Threading.Tasks.Task`1[System.String]
        Console.WriteLine($"Статус задачи: {dataTask.Status}"); // Running (или WaitingForActivation)
    
        // ОПАСНО: попытка использовать результат как строку
        // Console.WriteLine($"Длина данных: {dataTask.Length}"); // НЕ СКОМПИЛИРУЕТСЯ - у Task нет Length
    
        // Но если бы мы использовали var...
        var dangerousData = FetchDataAsync(); // компилятор выведет тип как Task<string>
        // Console.WriteLine(dangerousData.Length); // Тоже не скомпилируется
    }
}