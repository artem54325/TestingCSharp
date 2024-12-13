namespace TestingCSharp.ВопросыСобеседования;

public class ИнтернированиеСтрок
{
    public static void Main()
    {
        string a = new string(new char[0]);
        string b = string.Empty;
        string c = Foo();
        string d = "" + "";
        string e = "";
        
        Console.WriteLine(object.ReferenceEquals(a, b));
        Console.WriteLine(object.ReferenceEquals(a, c));
        Console.WriteLine(object.ReferenceEquals(a, d));
        Console.WriteLine(object.ReferenceEquals(a, e));
    }

    static string Foo()
    {
        return "";
    }
}