namespace Proglib_Patterns_HomeWork.Models;

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
        return new Vector(this.X + other.X, this.Y + other.Y);
    }
}
