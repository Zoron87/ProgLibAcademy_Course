using Proglib_Patterns_Course.Abstractions;
using Proglib_Patterns_Course.HomeWork_4.Abstractions;
using Proglib_Patterns_Course.HomeWork_4.Commands;

namespace Proglib_Patterns_Course.HomeWork_4.ExceptionHandlers;

public class ArgumentExceptionHandler : IExceptionHandler
{
    public bool CanHandle(Exception ex, ICommand command)
    {   
        return ex is ArgumentException;
    }

    public void Handle(Exception ex, ICommand command, CommandQueue commandQueue)
    {
        Console.WriteLine($"Возникла ошибка типа {ex.GetType().Name}!");
    }
}
