using System;
using System.Threading;

namespace A4
{
    public class SingleReminderThreadPool : ISingleReminder
    {

        public SingleReminderThreadPool(string a , int b)
        {
            Msg = a;
            Delay = b;
        }
        public int Delay {get;set;}

        public string Msg{get;set;}

        public event Action<string> Reminder;

        public void Start()
        {
            ThreadPool.QueueUserWorkItem((o) =>
            {
                Thread.Sleep(Delay);
                Reminder(Msg);
            });
        }
    }
}