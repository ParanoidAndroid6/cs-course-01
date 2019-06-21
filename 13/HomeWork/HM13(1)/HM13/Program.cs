using System;

namespace HM13
{
    class Program
    {
        static void Main(string[] args)
        {
            var ggg = new MultipleLogWriter(new ConsoleWriteLog(), new FileLogWriter("file"));
            ggg.LogError("Ошибка");
            ggg.LogInfo("Информация");
            ggg.LogWarning("Предупреждение");
            Console.ReadKey();
        }
    }
}
