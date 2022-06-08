using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace A4
{
    public static class ActionTools
    {
        public static long CallSequential(params Action[] actions)
        {
            Stopwatch w = Stopwatch.StartNew();
            foreach (var p in actions)
            {
                p();
            }
            return w.ElapsedMilliseconds;
        }

        public static long CallParallel(params Action[] actions)
        {
            Stopwatch w = Stopwatch.StartNew();
            Task[] n = new Task[actions.Length];
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = new Task(actions[i]);
                // n[i] =Task.Run(actions[i]);
                n[i].Start();
            }
            Task.WaitAll(n);
            return w.ElapsedMilliseconds;
        }

        public static long CallParallelThreadSafe(int count, params Action[] actions)
        {
            Stopwatch w = Stopwatch.StartNew();
            int j = 0;
            Task[] n = new Task[actions.Length];
            object _sync = new object();
            foreach(var o in actions)
            {
                n[j]=Task.Run(()=>{
                for (int i = 0; i < count; i++)
                {
                    lock(_sync)
                    {
                        o();
                    }
                }});
                j++;
            }
            Task.WaitAll(n);
            return w.ElapsedMilliseconds;
        }


        public static async Task<long> CallSequentialAsync(params Action[] actions)
        {
            Stopwatch w = Stopwatch.StartNew();
            foreach (var item in actions)
            {
                await Task.Run(item);
            }
            return w.ElapsedMilliseconds;
        }

        public static async Task<long> CallParallelAsync(params Action[] actions)
        {
            Stopwatch sw = Stopwatch.StartNew();
            // Task[] n = new Task[actions.Length];
            List<Task> n = new List<Task>();
            foreach (var item in actions)
            {
                n.Add(Task.Run(item));
            }
            await Task.WhenAll(n.ToArray());
            return sw.ElapsedMilliseconds;
        }

        public static async Task<long> CallParallelThreadSafeAsync(int count, params Action[] actions)
        {
            Stopwatch w = Stopwatch.StartNew();
            List<Task> tasks = new List<Task>();
            object _sync = new object();
            foreach (var p in actions)
            {
                tasks.Add(Task.Run(()=> 
                {
                    for (int i = 0; i < count; i++)
                    {
                        lock(_sync)
                        {
                            p();
                        }
                    }
                }
                ));
            }
            await Task.WhenAll(tasks);
            return w.ElapsedMilliseconds;
        }
    }
    // Stopwatch w = Stopwatch.StartNew();
    //         Task a = new Task(actions[0]);
    //         Task b = new Task(actions[1]);
    //         Task c = new Task(actions[2]);
    //         a.Start();b.Start();c.Start();

    //         a.Wait();b.Wait();c.Wait();

    //         return w.ElapsedMilliseconds;
}