using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP;

// High-Level Module depends on abstraction, not concrete classes
public interface ILogger { void Log(string message); }

// Low-Level Modules (Concrete Implementations)
public class FileLogger : ILogger
{
    public void Log(string message) { Console.WriteLine($"Logging to File: {message}"); }
}

public class DatabaseLogger : ILogger
{
    public void Log(string message) { Console.WriteLine($"Logging to Database: {message}"); }
}

// Factory to Control Object Creation (DIP Without DI Container)
public static class LoggerFactory
{
    public static ILogger GetLogger(string type)
    {
        return type switch
        {
            "File" => new FileLogger(),
            "Database" => new DatabaseLogger(),
            _ => throw new NotImplementedException()
        };
    }
}

// High-Level Module depends only on ILogger, not concrete classes
public class LogService
{
    private readonly ILogger _logger;

    public LogService(string loggerType)
    {
        _logger = LoggerFactory.GetLogger(loggerType);  // MAIN MAIN MAIN
    }

    public void LogMessage(string message)
    {
        _logger.Log(message);
    }
}

// Usage
class Program12
{
    static void Main()
    {
        LogService fileLogService = new LogService("File");
        fileLogService.LogMessage("Application started.");

        LogService dbLogService = new LogService("Database");
        dbLogService.LogMessage("User logged in.");
    }
}
