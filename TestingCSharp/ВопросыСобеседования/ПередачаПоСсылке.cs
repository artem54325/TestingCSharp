namespace TestingCSharp.ВопросыСобеседования;

public static class ПередачаПоСсылке
{
    public static void Start()
    {
        var linkClass = new SendLinkClass
        {
            TestValue = "FirstTestClass"
        };
        Console.WriteLine($"Linkclass start: {linkClass.TestValue}");
        ChangeLink(linkClass);
        Console.WriteLine($"Linkclass finish: {linkClass.TestValue}");
        ChangeLinkRef(ref linkClass);
        Console.WriteLine($"Linkclass finishRef: {linkClass.TestValue}");
    }

    private static void ChangeLink(SendLinkClass linkClass)
    {
        linkClass.TestValue = "Example";
        linkClass = new SendLinkClass
        {
            TestValue = "NewLinkClass"
        };
    }
    private static void ChangeLinkRef(ref SendLinkClass linkClass)
    {
        linkClass.TestValue = "Example";
        linkClass = new SendLinkClass
        {
            TestValue = "NewLinkClass"
        };
    }

    private class SendLinkClass
    {
        public string TestValue { get; set; }
    }
}