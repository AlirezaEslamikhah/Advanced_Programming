using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4
{
    public class SingleReminderTask : ISingleReminder
    {
        Task ReiminderTask = null;

        public SingleReminderTask(string a , int b)
        {
            Msg = a;
            Delay = b;
        }

        public int Delay{get;set;} 

        public string Msg {get;set;}

        public event Action<string> Reminder;

        public void Start()
        {
            ReiminderTask = Task.Run(()=>{
                Thread.Sleep(Delay);
            Reminder(Msg);
            });
            
        }
    }
}