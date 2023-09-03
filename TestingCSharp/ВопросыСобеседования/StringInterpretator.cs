using System.Text;

namespace TestingCSharp.ВопросыСобеседования;

public static class StringInterpretator
{
    public static void Start()
    {
        String s1 = "Hello";
        String s2 = "Hello";
        String s4 = "Hel" + "lo";
        String s5 = "Hel";
        s5 += "lo";
        String s6 = (string)s1.Clone();
        StringBuilder sb3 = new StringBuilder("Hello");
        Console.WriteLine(Object.ReferenceEquals(s1, s2));
        Console.WriteLine(Object.ReferenceEquals(s1, sb3.ToString()));
        Console.WriteLine(Object.ReferenceEquals(s1, s4));
        Console.WriteLine(Object.ReferenceEquals(s1, s5));
        Console.WriteLine(Object.ReferenceEquals(s1, s6));
        s1 = String.Intern(s1);
        s2 = String.Intern(s2);
        s4 = String.Intern(s4);
        s5 = String.Intern(s5);
        s6 = String.Intern(s6);
        var s3 = String.Intern(sb3.ToString());
        Console.WriteLine(Object.ReferenceEquals(s1, s2));
        Console.WriteLine(Object.ReferenceEquals(s1, s3));
        Console.WriteLine(Object.ReferenceEquals(s1, s4));
        Console.WriteLine(Object.ReferenceEquals(s1, s5));
        Console.WriteLine(Object.ReferenceEquals(s1, s6));
    }
}