using Proglib_Patterns_HomeWork.Models;

namespace Proglib_Patterns_HomeWork.Abstractions;

public interface IMoveable
{
    Vector Position { get; set; }
    Vector Velocity { get; set; }
}
