using System;
using System.IO;

namespace A4
{
    public enum ObserverType { Create, Delete }

    public class DirectoryWatcher : IDisposable
    {
        private string _dir;
        public static Action <string> c = null;
        public static Action<string> d = null; 
        public FileSystemWatcher watcher ;
        

        public DirectoryWatcher(string dir)
        {
            _dir = dir;
            watcher = new FileSystemWatcher(_dir); 
            watcher.Created+= invoke_change;
            watcher.Deleted+= invoke_change2;
            watcher.EnableRaisingEvents = true;
        }

        public static void invoke_change(object sender, FileSystemEventArgs args)
        {
            if (c != null)
            {
                // string n = "";
                c.Invoke(args.FullPath);
            }
        }
        public static void invoke_change2(object sender, FileSystemEventArgs args)
        {
            if (d != null)
            {
                // string n = "";
                d.Invoke(args.FullPath);
            }
        }


        public void Dispose()
        {
            watcher.Dispose();
        }

        public void Register(Action<string> notifyMe, ObserverType create)
        {
            if (create.ToString()== "Create")
            {
                c+= notifyMe;
            }
            if(create.ToString()== "Delete")
            {
                d+= notifyMe;
            }
        }

        public void Unregister(Action<string> notifyMe, ObserverType delete)
        {
            if (delete.ToString()== "Create")
            {
                c-= notifyMe;
            }
            if(delete.ToString()== "Delete")
            {
                d-= notifyMe;
            }
        }
    }
}