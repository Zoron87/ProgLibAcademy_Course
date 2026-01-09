using Proglib_Patterns_Course.Abstractions;

namespace Proglib_Patterns_Course.HomeWork_4.Commands;

public class CommandExample : ICommand
{
    public void Execute()
    {
        throw new ArgumentException();
    }
}
