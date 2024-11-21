namespace FinalProject
{
    internal class Program
    {
        
        static ILogger Logger { get; set; }
        static void Main()
        {
            Logger = new Logger();
            ISummation summation = new Calculator(Logger);

            //Calculator calculator = new Calculator(Logger);

            double x, y;

            while (true)
            {
                Console.Write("Введите первое число: ");
                string inputX = Console.ReadLine();

                Console.Write("Введите второе число: ");
                string inputY = Console.ReadLine();

                try
                {
                    x = double.Parse(inputX);
                    y = double.Parse(inputY);

                    double result = summation.ValueSumm(x, y);
                    Logger.Event("Выполнена операция суммирования");
                    Console.WriteLine($"Сумма: {result}");

                    break;
                }

                catch (FormatException)
                {
                    Logger.Error("Произошла ошибка: ");
                    Console.WriteLine("Некорректный ввод. Поробуйте еще раз.");
                }


            }
        }
    }

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }

    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
