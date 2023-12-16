using System.Collections;

namespace TestingCSharp.ВопросыСобеседования;

public class EqualsTest
{
    public static void Start()
    {
        var p1 = new Person { Name = "Jay", Age = 25 };
        var p2 = p1;
        var p3 = new Person { Name = "Jay", Age = 25 };

        Console.WriteLine(p1.Equals(p2));  // True
        Console.WriteLine(p1 == p2);       // True
        Console.WriteLine(p1.GetHashCode() == p2.GetHashCode());       // True
        
        Console.WriteLine(p1.Equals(p3));  // False
        Console.WriteLine(p1 == p3); // False
        Console.WriteLine(p1.GetHashCode() == p3.GetHashCode());       // False
    }

    private class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}