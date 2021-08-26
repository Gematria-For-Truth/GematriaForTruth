// Copyright (c) 2020 Gematria Tools
using System;
using System.IO;

namespace GematriaForTruth.API.Factory
{ 
    public class LoggerFactory
    {
        private static readonly object lockLog = new Object();
        private StreamWriter LogWriter { get; }
        private bool IsLogable { get; set; }
        public bool IsAlsoToConsole { get; set; }

        private static LoggerFactory logger = null;


        public static LoggerFactory Instance(string logDirectory = "", bool isAlsoToConsole = false)
        {
            if (logDirectory.Length == 0)
                logDirectory = GematriaFactory.Instance().GetLogDir();

            if (logger == null)
                logger = new LoggerFactory(logDirectory, isAlsoToConsole);

            return logger;
        }

        private LoggerFactory(string logDirectory = "", bool isAlsoToConsole = true)
        {
            this.IsAlsoToConsole = isAlsoToConsole;

            if (logDirectory.Length > 0)
            {
                try
                {
                    string logFile = logDirectory + "\\"
                    + DateTime.Now.Month + "_"
                    + DateTime.Now.Day
                    + "_" + DateTime.Now.Year
                    + "_" + DateTime.Now.Hour
                    + "_" + DateTime.Now.Minute
                    + "_" + DateTime.Now.Second
                    + ".txt";
                    LogWriter = new StreamWriter(logFile);
                    IsLogable = true;
                    LogMessage("Logger Started: " + DateTime.Now.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Logging Disabled");
                    IsLogable = false;
                }
            }
            else
                IsLogable = false;

        }

        public void LogException(Exception e, string message = "")
        {
            lock (lockLog)
            {
                try
                {
                    string log = "Logger: " + DateTime.Now.ToString();
                    if (IsAlsoToConsole)
                        Console.WriteLine(log);

                    if (IsLogable)
                        LogWriter.WriteLine(log);

                    if (IsAlsoToConsole)
                        Console.WriteLine(e.StackTrace.ToString());

                    if (IsLogable)
                    {
                        if (e != null)
                            LogWriter.WriteLine(e.StackTrace.ToString());
                    }

                    if (message.Length > 0)
                    {
                        log = "Application Message: " + message;

                        if (IsAlsoToConsole)
                            Console.WriteLine(log);

                        if (IsLogable)
                            LogWriter.WriteLine(log);
                    }

                    if (IsLogable)
                        LogWriter.Flush();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);

                    Console.WriteLine("Logger has crashed.  All message will now go directly to the console until the app is restarted.");
                    IsLogable = false;
                    IsAlsoToConsole = true;
                }
            }
        }

        public void LogMessage(string message)
        {
            lock (lockLog)
            {
                try
                {
                    string log = "Logger: " + DateTime.Now.ToString();
                    if (IsAlsoToConsole)
                        Console.WriteLine(log);

                    if (IsLogable)
                        LogWriter.WriteLine(log);

                    log = "Application Message: " + message;

                    if (IsAlsoToConsole)
                        Console.WriteLine(log);

                    if (IsLogable)
                        LogWriter.WriteLine(log);
                    if (IsLogable)
                        LogWriter.Flush();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);

                    Console.WriteLine("Logger has crashed.  All message will now go directly to the console until the app is restarted.");
                    IsLogable = false;
                    IsAlsoToConsole = true;
                }
            }
        }
    }
}

