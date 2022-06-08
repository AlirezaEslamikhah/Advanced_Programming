using System;
using System.Threading;

namespace A4
{
    public class SingleReminderThread : ISingleReminder
    {
        Thread ReiminderThread = null;
        public SingleReminderThread(string a , int b)
        {
            Msg = a;
            Delay = b;
            
        }
        // private System.Threading.Thread thredbegin(string obj)
        // {
        //     Thread.Sleep(Delay);
        //     Reminder(obj);
        // }
        public int Delay{get;}
        public string Msg{get;}
        public event Action<string> Reminder;
        // public static Thread a = new Thread(()=>{
        //         Thread.Sleep(Delay);
        //         Reminder(Msg);
        //     });

        public void Start()
        {
            // string w = "";
            // Reminder.Invoke(w);
            // ReiminderThread = thredbegin(Msg);
            ReiminderThread = new Thread(()=>{Thread.Sleep(Delay);Reminder(Msg);});
            ReiminderThread.Start();
        }
    }
}