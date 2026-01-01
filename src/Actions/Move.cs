using Proglib_Patterns_HomeWork.Abstractions;

namespace Proglib_Patterns_HomeWork.Actions;

public class Move
{
    private readonly IMoveable _moveable;
    public Move(IMoveable m)
    {
        _moveable = m;
    }

    public void Execute()
    {
        _moveable.Position = _moveable.Position.Plus(_moveable.Velocity);
    }
}
