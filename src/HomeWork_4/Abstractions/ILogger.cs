namespace Proglib_Patterns_Course.HomeWork_4.Abstractions;

public interface ILogger
{
    void Write(string message, Exception ex);
}
