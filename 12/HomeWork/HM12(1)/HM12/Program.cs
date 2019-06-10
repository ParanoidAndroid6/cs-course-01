using System;

namespace HM11
{
    class Program
    {
        static void Main(string[] args)
        {
            var u = new ReminderItem(DateTime.Now.AddHours(3), "WAKE UP!");
            var ii = new PhoneReminderItem(DateTime.Now.AddHours(3), "WAKE UP!", "+ 7(915)-130-34-16");
            u.WriteProperties();
            ii.WriteProperties();
            Console.ReadKey();
        }
    }
}
