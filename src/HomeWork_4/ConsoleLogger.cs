using Proglib_Patterns_Course.HomeWork_4.Abstractions;

namespace Proglib_Patterns_Course.HomeWork_4;

public class ConsoleLogger : ILogger
{
    public void Write(string message, Exception ex)
    {
        Console.WriteLine($"[LOG]: {message}");
        Console.WriteLine($"[StackTrace]: {ex}");
    }
}
