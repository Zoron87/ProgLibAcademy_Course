using Proglib_Patterns_Course.HomeWork_3;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Proglib_Patterns_HomeWork
{
    [ExcludeFromCodeCoverage]
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Решение квадратного уравнения");
            //ввод данных
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            var c = double.Parse(Console.ReadLine());

            Equation.Solve(a, b, c);

        }
    }
}
