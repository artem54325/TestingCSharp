namespace TestingCSharp.ВопросыСобеседования;
public class RefValueType
{
    public static void Start()
    {
        int valueType = 2;
        Console.WriteLine($"StartValue int {valueType}");
        UpdateInt(valueType);
        Console.WriteLine($"finishValue int {valueType}");
    }

    private static void UpdateInt(object valueType)
    {
        var w = (int)valueType;
        Console.WriteLine($"update int {w} {valueType}");
        w += 15;
        Console.WriteLine($"updated int {w} {valueType}");
    }
}


