// See https://aka.ms/new-console-template for more information

using System;

namespace Assignment3;
    public interface ILogger
    {
        bool writelog(string message);
    }
public class DatabaseLogger : ILogger
{
    public DatabaseLogger()
    {
        Console.WriteLine("Database Logger");
    }
    public bool writelog(string message)
    {
        Console.WriteLine("uploaded");
        return true;
    }
}
public class FileLogger : ILogger
{
    public FileLogger()
    {
        Console.WriteLine("File Logger");
    }
    public bool writelog(string message)
    {
        Console.WriteLine("Successfully done");
        return true;

    }
}
public class LogManager
{
    ILogger _logger = null;

    public LogManager(ILogger logger)
    {
        _logger = logger;
    }

    public bool writelog(string message)
    {

        return _logger.writelog(message);
    }
}



  public class Program
{
    public static ILogger getLog()
    {
        string Log = "Database";

        if (Log == "Database")
        {
            return new DatabaseLogger();
        }
        else
        {
            return new FileLogger();
        }
    }
    static void Main(string[] args)
    {
        ILogger log = getLog();
        LogManager logManager = new LogManager(log);
        logManager.writelog("Log Created");


    }
}