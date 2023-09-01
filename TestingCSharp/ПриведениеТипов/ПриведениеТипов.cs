namespace TestingCSharp.ПриведениеТипов;

public static class ПриведениеТипов
{
    public static void Start()
    {
        var model = new ModelClass
        {
            Param = "Param"
        };
        Приведение(model);
        Console.WriteLine($"Должен быть class 'Param' как в ините: {model.Param}");
        
        var modelStruct = new ModelStruct
        {
            Param = "Param"
        };
        ПриведениеStruct(modelStruct);
        Console.WriteLine($"Должен быть Struct 'Param' как в ините: {modelStruct.Param}");
        DateTime newYears = new DateTime(2013, 1, 1);
        Приведение(newYears);
    }

    private static void Приведение(object o)
    {
        var model = (ModelClass)o;
        model.Param = "класс";
    }
    private static void ПриведениеStruct(object o)
    {
        var model = (ModelStruct)o;
        model.Param = "структура";
    }
    private class ModelClass
    {
        public string Param { get; set; }
    }    
    private struct ModelStruct
    {
        public string Param { get; set; }

    }
}
