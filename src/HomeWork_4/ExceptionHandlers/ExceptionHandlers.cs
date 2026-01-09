using Proglib_Patterns_Course.Abstractions;
using Proglib_Patterns_Course.HomeWork_4.Abstractions;

namespace Proglib_Patterns_Course.HomeWork_4.ExceptionHandlers;

public class ExceptionHandlers
{
    private readonly List<IExceptionHandler> _handlers = new();

    public ExceptionHandlers(IEnumerable<IExceptionHandler> handlers)
    {
        _handlers.AddRange(handlers);
    }

    public IExceptionHandler Select(Exception ex, ICommand command)
    {
        foreach (var handler in _handlers)
        {
            if (handler.CanHandle(ex, command))
                return handler;
        }

        throw new InvalidOperationException("Не найден обработчик для данного исключения");
    }
}
