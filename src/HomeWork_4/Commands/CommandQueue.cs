using Proglib_Patterns_Course.Abstractions;

namespace Proglib_Patterns_Course.HomeWork_4.Commands;

public class CommandQueue
{
    private readonly Queue<ICommand> _queue = new();

    public void Enqueue(ICommand command)
    {
        _queue.Enqueue(command);
    }

    public bool TryDequeue(out ICommand? command)
    {
        if (_queue.Count == 0)
        {
            command = null;
            return false;
        }

        command = _queue.Dequeue();
        return true;
    }
}
