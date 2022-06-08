using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Logger
{
    public static class FileLoggerFactory
    {
        public static FileLogger<ConcurrentLogWriter> con_null_inc_con(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<ConcurrentLogWriter>(
            ConsoleLogFormatter.Instance,
            new NullPrivacyScrubber(),
            new IncrementalLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);

        public static FileLogger<ConcurrentLogWriter> con_all_inc_con(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<ConcurrentLogWriter>(
            ConsoleLogFormatter.Instance,
            PrivacyScrubberFactory.ScrubAll(),
            new IncrementalLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);

        public static FileLogger<ConcurrentLogWriter> con_all_inc_csv(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<ConcurrentLogWriter>(
            CsvLogFormatter.Instance,
            PrivacyScrubberFactory.ScrubAll(),
            new IncrementalLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<ConcurrentLogWriter> con_all_inc_xml(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<ConcurrentLogWriter>(
            XmlLogFormatter.Instance,
            PrivacyScrubberFactory.ScrubAll(),
            new IncrementalLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<ConcurrentLogWriter> con_all_time_con(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<ConcurrentLogWriter>(
            ConsoleLogFormatter.Instance,
            PrivacyScrubberFactory.ScrubAll(),
            new TimeBasedLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<ConcurrentLogWriter> con_all_time_csv(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<ConcurrentLogWriter>(
            CsvLogFormatter.Instance,
            PrivacyScrubberFactory.ScrubAll(),
            new TimeBasedLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<ConcurrentLogWriter> con_all_time_xml(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<ConcurrentLogWriter>(
            XmlLogFormatter.Instance,
            PrivacyScrubberFactory.ScrubAll(),
            new TimeBasedLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<ConcurrentLogWriter> con_null_inc_csv(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<ConcurrentLogWriter>(
            CsvLogFormatter.Instance,
            new NullPrivacyScrubber(),
            new IncrementalLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<ConcurrentLogWriter> con_null_inc_xml(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<ConcurrentLogWriter>(
            XmlLogFormatter.Instance,
            new NullPrivacyScrubber(),
            new IncrementalLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<ConcurrentLogWriter> con_null_time_con(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<ConcurrentLogWriter>(
            ConsoleLogFormatter.Instance,
            new NullPrivacyScrubber(),
            new TimeBasedLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<ConcurrentLogWriter> con_null_time_csv(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<ConcurrentLogWriter>(
            CsvLogFormatter.Instance,
            new NullPrivacyScrubber(),
            new TimeBasedLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<ConcurrentLogWriter> con_null_time_xml(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<ConcurrentLogWriter>(
            XmlLogFormatter.Instance,
            new NullPrivacyScrubber(),
            new TimeBasedLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<LockedLogWriter> lock_all_inc_con(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<LockedLogWriter>(
            ConsoleLogFormatter.Instance,
            PrivacyScrubberFactory.ScrubAll(),
            new IncrementalLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<LockedLogWriter> lock_all_inc_csv(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<LockedLogWriter>(
            CsvLogFormatter.Instance,
            PrivacyScrubberFactory.ScrubAll(),
            new IncrementalLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<LockedLogWriter> lock_all_inc_xml(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<LockedLogWriter>(
            XmlLogFormatter.Instance,
            PrivacyScrubberFactory.ScrubAll(),
            new IncrementalLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<LockedLogWriter> lock_all_time_con(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<LockedLogWriter>(
            ConsoleLogFormatter.Instance,
            PrivacyScrubberFactory.ScrubAll(),
            new TimeBasedLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<LockedLogWriter> lock_all_time_csv(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<LockedLogWriter>(
            CsvLogFormatter.Instance,
            PrivacyScrubberFactory.ScrubAll(),
            new TimeBasedLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<LockedLogWriter> lock_all_time_xml(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<LockedLogWriter>(
            XmlLogFormatter.Instance,
            PrivacyScrubberFactory.ScrubAll(),
            new TimeBasedLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<LockedLogWriter> lock_null_inc_con(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<LockedLogWriter>(
            ConsoleLogFormatter.Instance,
            new NullPrivacyScrubber(),
            new IncrementalLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<LockedLogWriter> lock_null_inc_csv(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<LockedLogWriter>(
            CsvLogFormatter.Instance,
            new NullPrivacyScrubber(),
            new IncrementalLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<LockedLogWriter> lock_null_inc_xml(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<LockedLogWriter>(
            XmlLogFormatter.Instance,
            new NullPrivacyScrubber(),
            new IncrementalLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<LockedLogWriter> lock_null_time_con(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<LockedLogWriter>(
            ConsoleLogFormatter.Instance,
            new NullPrivacyScrubber(),
            new TimeBasedLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<LockedLogWriter> lock_null_time_csv(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<LockedLogWriter>(
            CsvLogFormatter.Instance,
            new NullPrivacyScrubber(),
            new TimeBasedLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        public static FileLogger<LockedLogWriter> lock_null_time_xml(string logdir , string logprefix , HashSet<LogLevel> level , HashSet<LogSource> source,
        bool append)=> new FileLogger<LockedLogWriter>(
            XmlLogFormatter.Instance,
            new NullPrivacyScrubber(),
            new TimeBasedLogFileName(logdir,logprefix,ConsoleLogFormatter.Instance.FileExtention),
            level,source,append);
        
    }
}