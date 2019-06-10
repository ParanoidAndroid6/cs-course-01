using System;

namespace HM11
{
    public partial class PhoneReminderItem : ReminderItem
    {
        public string PhoneNumber { get; set; }
        public PhoneReminderItem(DateTimeOffset date, string message, string number) : base(date, message)
        {
            PhoneNumber = number;
        }
        
        public override void WriteProperties()
        {
          Console.WriteLine($" Alarm message: {AlarmMessage}\n" +
              $" Send to phone number: {PhoneNumber}\n" +
              $" Alarm date: {AlarmDate}\n" +
              $" Time to alarm: {TimeToAlarm}\n" +
              $" Is alarm outdated: {IsOutDated}\n" +
              $"Type: { GetType()}\n"); 
        }

    }
}
