using Proglib_Patterns_Course.Abstractions;
using Proglib_Patterns_Course.HomeWork_4.Abstractions;
using Proglib_Patterns_Course.HomeWork_4.Commands;

namespace Proglib_Patterns_Course.HomeWork_4.ExceptionHandlers;

public class RetryFirstFailureHandler : IExceptionHandler
{
    public bool CanHandle(Exception ex, ICommand command)
    {
        return command is not RetryCommand;
    }

    public void Handle(Exception ex, ICommand command, CommandQueue commandQueue)
    {
        commandQueue.Enqueue(new RetryCommand(command));
    }
}
