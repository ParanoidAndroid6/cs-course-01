using System;

namespace HM11
{
    class Program
    {
        static void Main(string[] args)
        {
            var u = new ReminderItem(DateTime.Now.AddHours(3), "WAKE UP!");
            var ii = new PhoneReminderItem(DateTime.Now.AddHours(3), "WAKE UP!", "+ 7(915)-130-34-16");
            var iii = new ChatReminderItem(DateTime.Now.AddHours(3), "WAKE UP!", "+ 7(915)-130-34-16", "Wakey Wakey", "Ura");
            u.WriteProperties();
            ii.WriteProperties();
            iii.WriteProperties();
            Console.ReadKey();
        }
    }
}
