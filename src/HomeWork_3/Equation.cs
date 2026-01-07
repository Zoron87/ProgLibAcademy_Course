namespace Proglib_Patterns_Course.HomeWork_3;

public static class Equation
{
    public static double[] Solve(double a, double b, double c)
    {
        double x1 = 0.0;
        double x2 = 0.0;

        if (!double.IsFinite(a) || !double.IsFinite(b) || !double.IsFinite(c))
        {
            throw new ArgumentException("Коэффициенты 'a, b, c' должны быть конечными числами");
        }

        var discriminant = Math.Pow(b, 2) - 4 * a * c;

        var eps = 1e-7;
        if (Math.Abs(a) < eps)
            throw new ArgumentException("Коэффициент 'a' не может быть равен нулю", nameof(a));

        if (discriminant < -eps)
        {
            return Array.Empty<double>();
            
        }

        if (Math.Abs(discriminant) < eps)
        { 
            x1 = -b / (2 * a);
            x2 = x1;
        }

        if (discriminant > eps)
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        }
            
        return x1 > x2 ? new double[] { x2, x1 } : new double[] { x1, x2 };
    }
}
