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
        
        Console.WriteLine("==");
        Console.WriteLine(s1 == s2); // true
        Console.WriteLine(s1 == s4); // true
        Console.WriteLine(s1 == s5); // true
        Console.WriteLine(s1 == s6); // true
        Console.WriteLine("REf");
        Console.WriteLine(Object.ReferenceEquals(s1, s2)); // true
        Console.WriteLine(Object.ReferenceEquals(s1, sb3.ToString())); // false
        Console.WriteLine(Object.ReferenceEquals(s1, s4));// true
        Console.WriteLine(Object.ReferenceEquals(s1, s5));// false
        Console.WriteLine(Object.ReferenceEquals(s1, s6));// true
        s1 = String.Intern(s1);
        s2 = String.Intern(s2);
        s4 = String.Intern(s4);
        s5 = String.Intern(s5);
        s6 = String.Intern(s6);
        var s3 = String.Intern(sb3.ToString());
        Console.WriteLine(Object.ReferenceEquals(s1, s2)); // true
        Console.WriteLine(Object.ReferenceEquals(s1, s3)); // true
        Console.WriteLine(Object.ReferenceEquals(s1, s4)); // true
        Console.WriteLine(Object.ReferenceEquals(s1, s5)); // true
        Console.WriteLine(Object.ReferenceEquals(s1, s6)); // true
        
        
        
        
        
        string a = "Test";
        string b = a;
        string c = "Test";

        Console.WriteLine(a == c);
        changeStr(ref b);
        a += "changed";
        Console.WriteLine(a == b);

        static void changeStr(ref string s)
        {
            s += "changed";
        }

    }
}