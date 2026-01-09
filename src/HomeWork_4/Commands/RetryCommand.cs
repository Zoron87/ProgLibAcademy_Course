using Proglib_Patterns_Course.Abstractions;

namespace Proglib_Patterns_Course.HomeWork_4.Commands;

public class RetryCommand : ICommand
{
    public readonly ICommand Original;

    public RetryCommand(ICommand command)
    {
        Original = command;
    }
    public void Execute()
    {
        Original.Execute();
    }
}
