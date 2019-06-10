using System;

namespace HM11
{
    public partial class PhoneReminderItem
    {
        public class ChatReminderItem : PhoneReminderItem
        {
            public string ChatName { get; set; }
            public string AccountName { get; set; }
            public ChatReminderItem (DateTimeOffset date, string message, string number, string chatN, string accN) : base(date, message, number)
            {
                ChatName = chatN;
                AccountName = accN;
            }
            public override void WriteProperties()
            {
                Console.WriteLine($"Account name: {AccountName}\n " +
                    $"Chat name: {ChatName}\n " +
                    $"Alarm message: {AlarmMessage}\n " +
                    $"Send to phone number: {PhoneNumber}\n " +
                    $"Alarm date: {AlarmDate}\n" +
                    $" Time to alarm: {TimeToAlarm}\n" +
                    $" Is alarm outdated: {IsOutDated}\n" +
                    $" Type: {GetType()}\n");

            }
        }
    }
}
