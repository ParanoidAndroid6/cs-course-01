using System;

namespace HM11
{
    public class ReminderItem
    {
        public DateTimeOffset AlarmDate { get; set; }
        public string AlarmMessage { get; set; }
        public TimeSpan TimeToAlarm => TimeSpan.Parse($"{DateTime.Now - AlarmDate}"); 
        public bool IsOutDated
        {
            get
            {
                if (TimeToAlarm < TimeSpan.Zero)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public virtual void WriteProperties()
        {
            Console.WriteLine($"Alarm date: {AlarmDate}\n" +
                $" Alarm message: {AlarmMessage}\n" +
                $" Time to alarm: {TimeToAlarm}\n" +
                $" Is alarm outdated: {IsOutDated}\n" +
                $" Type: { GetType()}\n"); 
        }
        public ReminderItem(DateTimeOffset date, string message)
        {
            AlarmDate = date;
            AlarmMessage = message;
        }
    }
}
