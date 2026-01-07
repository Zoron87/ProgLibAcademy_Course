namespace Proglib_Patterns_Course.Models;

public record Vector
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector(int x, int y)
    {
        X = x; 
        Y = y;
    }

    public Vector Plus(Vector other)
    {
        return new Vector(X + other.X, Y + other.Y);
    }
}
