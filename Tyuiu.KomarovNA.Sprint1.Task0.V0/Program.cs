using Tyuiu.KomarovNA.Sprint1.Task0.V0.Lib;

namespace Tyuiu.KomarovNA.Sprint1.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = DataService.CalcExpression(24, 6, 2, 24, 6, 4);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}