namespace TestingCSharp.ВопросыСобеседования;

public static class TryCatchTest
{
    public static void Start()
    {
        try
        {
            // Внутрь блока try помещают код, требующий корректного
            // восстановления работоспособности или очистки ресурсов
            ExceptionRun();
        }
        catch (IOException e)
        {
            Console.WriteLine("IOException e");
            // throw e; // Повторная генерация перехваченного исключения
            /*
             * Unhandled exception. System.IO.IOException
   at TestingCSharp.ВопросыСобеседования.TryCatchTest.Start() in C:\Users\chilo\
RiderProjects\TestingCSharp\TestingCSharp\ВопросыСобеседования\TryCatchTest.cs:l
ine 16
   at Program.<Main>$(String[] args) in C:\Users\chilo\RiderProjects\TestingCSha
rp\TestingCSharp\Program.cs:line 50

             */

            throw; // Повторная генерация перехваченного исключения
            /*
             * Unhandled exception. System.IO.IOException
   at TestingCSharp.ВопросыСобеседования.TryCatchTest.ExceptionRun() in C:\Users\chilo\RiderProjects\TestingCSharp\TestingCSharp\ВопросыСобеседования\TryCatchTest.cs:line 49
   at TestingCSharp.ВопросыСобеседования.TryCatchTest.Start() in C:\Users\chilo\RiderProjects\TestingCSharp\TestingCSharp\ВопросыСобеседования\TryCatchTest.cs:line 11
   at Program.<Main>$(String[] args) in C:\Users\chilo\RiderProjects\TestingCSharp\TestingCSharp\Program.cs:line 50

             */
        }
        catch (Exception e)
        {
            // До C# 2.0 этот блок перехватывал только CLS-совместимые исключения
            // В C# 2.0 этот блок научился перехватывать также
            // CLS-несовместимые исключения
            Console.WriteLine("Exception e");
            throw; // Повторная генерация перехваченного исключения
        }
        catch
        {
            Console.WriteLine("catch");
            // Во всех версиях C# этот блок перехватывает
            // и совместимые, и несовместимые с CLS исключения
            throw; // Повторная генерация перехваченного исключения
        }
    }

    private static void ExceptionRun()
    {
        Console.WriteLine("ExceptionRun");
        throw new IOException("");
    }
}