using Tyuiu.KomarovNA.Sprint1.Task2.V7.Lib;

namespace Tyuiu.KomarovNA.Sprint1.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Комаров Никита Алексеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Комаров Никита Алексеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные, в*");
            Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране. Формулировка *");
            Console.WriteLine("* задания: Известен радиус круга. Вычислить примерную площадь круга. Ответ*");
            Console.WriteLine("*т округлите до 3 знаков после запятой. Что пользователь вводит? Радиус кр*");
            Console.WriteLine("*руга (целое число) Что программа печатает на экране? Площадь круга (вещес*");
            Console.WriteLine("*ственное число)                                                          *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            DataService ds = new DataService();

            int r = int.Parse(Console.ReadLine());
            double result = ds.CalculateSquareCircle(r);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}