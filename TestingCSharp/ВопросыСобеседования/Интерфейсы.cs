namespace TestingCSharp.ВопросыСобеседования;

public interface IWindow {
    void GetMenu();
}
public interface IRestaurant {
    void GetMenu();
}
public sealed class MarioPizzeria : IWindow, IRestaurant {
    // Реализация метода GetMenu интерфейса IWindow
    void IWindow.GetMenu() {Console.WriteLine("IWindow.GetMenu"); }
    // Реализация метода GetMenu интерфейса IRestaurant
    void IRestaurant.GetMenu() { Console.WriteLine("IRestaurant.GetMenu"); }
    // Метод GetMenu (необязательный),
    // не имеющий отношения к интерфейсу
    public void GetMenu()
    {
        Console.WriteLine("MarioPizzeria.GetMenu");
    }
}
public static class Интерфейсы
{
    public static void Start()
    {
        MarioPizzeria mp = new MarioPizzeria();
// Эта строка вызывает открытый метод GetMenu класса MarioPizzeria
        mp.GetMenu();
// Эти строки вызывают метод IWindow.GetMenu
        IWindow window = mp;
        window.GetMenu();
// Эти строки вызывают метод IRestaurant.GetMenu
        IRestaurant restaurant = mp;
        restaurant.GetMenu();
    }
}