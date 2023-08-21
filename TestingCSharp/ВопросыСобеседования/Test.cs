using System;
					
public class Test
{
    private class GenericTest<T>
    {
        private static int number = 0; 
        public GenericTest()
        {
            ++number;
        }

        public int getNumber()
        {
            return number;
        }
    }

    private class Resolution
    {
        public int width = 1920;
        public int height = 1080;
    }
    public static void init()
    {
		
        var hd = new Resolution();
        var cinema = hd;
        cinema.width = 1000;
        Console.WriteLine(hd.width);
    }
    
    public static void init2()
    {
        Console.WriteLine($"{Compare("dog", "dgo")} ==  true");
        Console.WriteLine($"{Compare("dog", "dfo")} ==  false");
        Console.WriteLine($"{Compare("dogd", "ddog")} ==  true");
        Console.WriteLine($"{Compare("doog", "ddog")} ==  false");
    }
    public static void init3()
    {
        GenericTest<object> test1 = new GenericTest<object>();
        GenericTest<string> test2 = new GenericTest<string>();
        GenericTest<int> test3 = new GenericTest<int>();
        Console.WriteLine($"Гет нутбер {test3.getNumber()}");
    }

    private static bool Compare(string text1, string text2)
    {
        if (!IsInValidate(text1, text2)) 
            return false;
        
        var keys1 = text1
            .GroupBy(q => q, (charVar, list) => new { charVar, count = list.Count() })
            .ToDictionary(q => q, q => q.count);
        var keys2 = text2
            .GroupBy(q => q, (charVar, list) => new { charVar, count = list.Count() })
            .ToDictionary(q => q, q => q.count);
        if (keys1.Count != keys2.Count)
            return false;

        foreach (var k in keys1)
        {
            if (!keys2.ContainsKey(k.Key))
                return false;
            if (keys2[k.Key] != k.Value)
                return false;
        }

        return true;
    }

    private static bool IsInValidate(string text1, string text2)
    {
        if (string.IsNullOrEmpty(text1) || string.IsNullOrEmpty(text2))
            return false;
        if (text2.Length != text1.Length)
            return false;
        return true;
    }
}