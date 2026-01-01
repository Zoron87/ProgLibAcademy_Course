using Proglib_Patterns_HomeWork.Abstractions;

namespace Proglib_Patterns_HomeWork.Actions;

public class Rotate
{
    private readonly IRotatable _rotatable;
    public Rotate(IRotatable r)
    {
        _rotatable = r;
    }

    public void Execute()
    {
        _rotatable.Direction += _rotatable.AngularVelocity;
    }
}
