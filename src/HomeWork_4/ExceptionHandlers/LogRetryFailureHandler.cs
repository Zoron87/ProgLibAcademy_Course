using Proglib_Patterns_Course.Abstractions;
using Proglib_Patterns_Course.HomeWork_4.Abstractions;
using Proglib_Patterns_Course.HomeWork_4.Commands;

namespace Proglib_Patterns_Course.HomeWork_4.ExceptionHandlers;

public class LogRetryFailureHandler : IExceptionHandler
{
    private readonly ILogger _logger;

    public LogRetryFailureHandler(ILogger logger)
    {
        _logger = logger;
    }
    public bool CanHandle(Exception ex, ICommand command)
    {
        return command is RetryCommand;
    }

    public void Handle(Exception ex, ICommand command, CommandQueue commandQueue)
    {
        var retryCommand = command as RetryCommand;
        commandQueue.Enqueue(new LogExceptionCommand(_logger, ex, retryCommand.Original));
    }
}
