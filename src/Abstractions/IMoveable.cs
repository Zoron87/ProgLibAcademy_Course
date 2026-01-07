using Proglib_Patterns_Course.Models;

namespace Proglib_Patterns_Course.Abstractions;

public interface IMoveable
{
    Vector Position { get; set; }
    Vector Velocity { get; set; }
}
