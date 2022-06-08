using System;
using System.IO;

namespace A4
{

    public class SingleFileWatcher : IDisposable
    {
        private FileSystemWatcher Watcher;

        public string f_path { get; set; }
        public static Action change { get; set; }

        public SingleFileWatcher(string file)
        {
            f_path = file;
            Watcher = new FileSystemWatcher(Path.GetDirectoryName(f_path), Path.GetFileName(f_path)); 
            Watcher.EnableRaisingEvents = true; //
            Watcher.Changed += invoke_change;
        }
        public static void invoke_change(object sender, FileSystemEventArgs args)
        {
            // change?.Invoke();//
            if (change != null)
            {
                change.Invoke();
            }
        }

        public void Register(Action n)
        {
            change += n;
        }

        public void Dispose()
        {
            if (Watcher != null)
                Watcher.Dispose();
        }

        public void Unregister(Action n)
        {
            // Watcher.Changed -= (object sender, FileSystemEventArgs args)=>n();
            change -= n;
        }

        // s=Path.GetDirectoryName(file);
        //             Watcher = new FileSystemWatcher(file,file
        //             );
    }
}