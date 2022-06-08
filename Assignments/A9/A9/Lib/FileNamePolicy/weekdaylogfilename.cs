using System;
using System.IO;
using System.Linq;

namespace Logger
{
    public class  WeekdayLogFileName : LogFileNamePolicy
    {
        public WeekdayLogFileName (string logDir, string logPrefix, string logExt) 
            : base(logDir, logPrefix, logExt)
        { }

        public override string NextFileName() => 
            Path.Combine(LogDir, 
                $"{LogPrefix}_{date.Substring(0,3)}.{LogExt}");
        public string date => DateTime.Today.DayOfWeek.ToString();

        protected int LastLogNumber
        {
            get
            {
                string[] files = Directory.GetFiles(this.LogDir, $"{LogPrefix}_*.{LogExt}");
                return files.Length == 0 ? -1 :
                    files.Select(f => f.Substring(0, f.Length - LogExt.Length-1)
                                        .Substring(f.LastIndexOf('_') + 1))
                            .Max(n => int.Parse(n));
            }
        }

    }
}