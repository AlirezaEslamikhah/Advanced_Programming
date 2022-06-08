using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Logger.Tests
{
    [TestClass()]
    public class LogWriterPerfTests
    {
        [TestMethod()]
        public void LockedLogWriterPerfTest()
        {
            var time = PerfTest<LockedLogWriter>(threadCount:1, linePerThread:1000);
            System.Console.WriteLine(time);
        }

        [TestMethod()]
        public void ConcurrentLogWriterPerfTest()
        {
            var time = PerfTest<ConcurrentLogWriter>(threadCount: 1, linePerThread: 1000);
            System.Console.WriteLine(time);
        }

        [TestMethod()]
        public void LockedQueueLogWriter()
        {
            var time = PerfTest<LockedQueueLogWriter>(threadCount:1,linePerThread: 1000);
            System.Console.WriteLine(time);
        }

        // [TestMethod()]
        // public void NoLockPerfTest()
        // {
        //     var time = PerfTest<NoLockLogWriter>(threadCount: 25, linePerThread: 1000);
        //     //این تست اکسپشن میدهد زیر این کلاس نسبت به ان دو کلاس بالاتر قاعده و قانون خاصی برای 
        //     //صبر کردن در نظر نگرفته پس به ناچار ترد ها عملکردشان مختل میشود زیرا همزمان درحال انجام کاری هستند 
        //     // دو کلاس بالاتر یکی با لاک و یکی با صبر کردن مانع وقوع این اتفاق شده اند
        // }

        private string PerfTest<_LogWriter>(int threadCount, int linePerThread)
            where _LogWriter: GuardedLogWriter, new()
        {
            string logDir = Path.GetTempFileName();
            File.Delete(logDir);
            string logPrefix = "sauleh_all";
            string time = string.Empty;
            using (FileLogger<_LogWriter> logger = new FileLogger<_LogWriter>(
                    XmlLogFormatter.Instance,
                    new PrivacyScrubber(PhoneNumberScrubber.Instance, IDScrubber.Instance, FullNameScrubber.Instance),
                    new TimeBasedLogFileName(logDir, logPrefix, XmlLogFormatter.Instance.FileExtention),
                    LogLevels.All,
                    LogSources.All,
                    false)) 
            {
                var threads = Enumerable.Range(0, threadCount)
                                        .Select(n => new Thread(
                                            new ThreadStart(() => LogRandomMessages(linePerThread, logger))))
                                        .ToList();

                Stopwatch sw = Stopwatch.StartNew();
                threads.ForEach(t => t.Start());
                threads.ForEach(t => t.Join());
                sw.Stop();

                time = sw.Elapsed.TotalSeconds.ToString();
                
            }

            int actualLogLines = CountLogLines(logDir, pattern: $"{logPrefix}*.{XmlLogFormatter.Instance.FileExtention}");

            Assert.AreEqual(linePerThread * threadCount + 2, actualLogLines); // plus 2 for header and footer

            return time;
        }

        private int CountLogLines(string logDir, string pattern)
        {
            return Directory.GetFiles(logDir, pattern).Sum(f => File.ReadAllLines(f).Length);
        }

        private void  LogRandomMessages(int count, ILogger logger)
        {
            for (int i=0; i<count; i++)
            {
                LogEntry logEntry = new LogEntry(LogSource.Client, LogLevel.Debug,
                    $"student {i} created", ("FirstName", $"Pegah_{i}"), ("LastName", $"Ayati_{i}"));
                logger.Log(logEntry);
            }
        }
    }
}


//   number   concurrentLogWriter       LockedLogWriter     LockedQueueLogWriter   thread 
//      1           1.1448776             1.4447263             0.9184198            25 
//      2           0.2600966             0.2687292             0.1649734             1
//      3           0.4368998             0.3421656             0.2236                5
//      4           3.0673287             2.6937698             2.0913283            50
//      5           6.7928527             6.240386              4.8877187            100
//      6           213.2808019           110.0646331           209.139843           1000