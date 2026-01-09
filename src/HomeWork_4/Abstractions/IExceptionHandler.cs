using Proglib_Patterns_Course.Abstractions;
using Proglib_Patterns_Course.HomeWork_4.Commands;

namespace Proglib_Patterns_Course.HomeWork_4.Abstractions;

public interface IExceptionHandler
{
    bool CanHandle(Exception ex, ICommand command);
    void Handle(Exception ex, ICommand command, CommandQueue commandQueue);
}
