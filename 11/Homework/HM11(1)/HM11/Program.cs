using System;

namespace HM11
{
    class ReminderItem
    {
        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessage { get; set; }
        public TimeSpan TimeToAlarm => TimeSpan.Parse($"{DateTime.Now - AlarmDate}");
        public bool IsOutDated { get; set; }
        public void WriteProperties()
        {
            Console.WriteLine($"Alarm date: {AlarmDate}, Alarm message: {AlarmMessage}, Time to alarm: {TimeToAlarm} ");
        }
        public ReminderItem()
        {
            AlarmDate = DateTime.Now.AddHours(3);
            AlarmMessage = "WAKE UP!";
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
            var u = new ReminderItem();
            u.WriteProperties();
            Console.ReadKey();
            }
        }
    }

