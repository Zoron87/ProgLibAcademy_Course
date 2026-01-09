using Proglib_Patterns_Course.Abstractions;
using Proglib_Patterns_Course.HomeWork_4.Abstractions;

namespace Proglib_Patterns_Course.HomeWork_4.Commands;

public class LogExceptionCommand : ICommand
{
    private readonly ILogger _logger;
    private readonly Exception _exception;
    private readonly ICommand _command;

    public LogExceptionCommand(ILogger logger, Exception exception, ICommand command)
    {
        _logger = logger;
        _exception = exception;
        _command = command;
    }

    public void Execute()
    {
        _logger.Write($"Команда {_command} завершилась с ошибкой: {_exception.GetType().Name}", _exception);
    }
}
