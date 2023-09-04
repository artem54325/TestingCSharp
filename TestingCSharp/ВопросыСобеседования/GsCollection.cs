namespace TestingCSharp.ВопросыСобеседования;

public static class GsCollection
{
    public static void Start() {
        // Создание объекта Timer, вызывающего метод TimerCallback
        // каждые 2000 миллисекунд
        Timer t = new Timer(TimerCallback, null, 0, 2000);
        // Ждем, когда пользователь нажмет Enter
        Console.ReadLine();
    }
    static void TimerCallback(object? o) {
        // Вывод даты/времени вызова этого метода
        Console.WriteLine("In TimerCallback: " + DateTime.Now);
        // Принудительный вызов уборщика мусора в этой программе
        GC.Collect();
    }
}