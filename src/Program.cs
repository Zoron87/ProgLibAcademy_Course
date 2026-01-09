using Proglib_Patterns_Course.HomeWork_3;
using Proglib_Patterns_Course.HomeWork_4;
using Proglib_Patterns_Course.HomeWork_4.Abstractions;
using Proglib_Patterns_Course.HomeWork_4.Commands;
using Proglib_Patterns_Course.HomeWork_4.ExceptionHandlers;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Proglib_Patterns_HomeWork
{
    [ExcludeFromCodeCoverage]
    public class Program
    {
        static void Main(string[] args)
        {
            var logger = new ConsoleLogger();

            var command = new CommandExample();
            CommandQueue commandQueue = new CommandQueue();
            commandQueue.Enqueue(command);

            var exceptionHandlers = new ExceptionHandlers
            (
                new List<IExceptionHandler>()
                {
                    new LogRetryFailureHandler(logger),
                    new RetryFirstFailureHandler()
                }
            );

            while (commandQueue.TryDequeue(out var cmd) && cmd is not null)
            {
                try
                {
                    cmd.Execute();
                }
                catch (Exception ex)
                {
                    var handler = exceptionHandlers.Select(ex, cmd);
                    handler.Handle(ex, cmd, commandQueue);
                }
            }

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
