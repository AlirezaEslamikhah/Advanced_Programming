using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class  XsvLogFormatter :ILogFormatter
    {
        public static string jodakonnande{get;set;} 
        public XsvLogFormatter(string splitter)
        {
            jodakonnande = splitter;
        }

        private static XsvLogFormatter _Instance;

        private static XsvLogFormatter Instance => _Instance ?? (_Instance = new XsvLogFormatter(jodakonnande));

        public string Header => $"level{jodakonnande}date{jodakonnande}source{jodakonnande}threadId{jodakonnande}ProcessId{jodakonnande}message{jodakonnande}name:value pairs";

        public string Footer => string.Empty;

        public string FileExtention => "log";

        public string Format(LogEntry entry)
        {
            return $"{entry.Level.ToString()}{jodakonnande}{entry.DateTime.ToString()}{jodakonnande}{entry.Source.ToString()}," +
                $"{entry.ThreadId.ToString()}{jodakonnande}{entry.ProcessId}{jodakonnande}{entry.Message}," +
                    string.Join(jodakonnande , entry.NameValuePairs.Select(v => $"'{v.name}':'{v.value}'"));
        }
    }
}