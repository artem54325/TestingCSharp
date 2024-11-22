namespace TestingCSharp.ВопросыСобеседования;

public class ИнтернированиеСтрок
{
    public static void Main()
    {
        string a = new string(new char[0]);
        string b = string.Empty;
        string c = Foo();
        Console.WriteLine(object.ReferenceEquals(a, b));
        Console.WriteLine(object.ReferenceEquals(a, c));
    }

    static string Foo()
    {
        return "";
    }
}