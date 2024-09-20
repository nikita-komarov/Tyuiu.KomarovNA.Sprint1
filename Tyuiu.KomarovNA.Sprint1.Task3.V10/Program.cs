using Tyuiu.KomarovNA.Sprint1.Task3.V10.Lib;

namespace Tyuiu.KomarovNA.Sprint1.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Комаров Никита Алексеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Операторы составного присваивания:                                      *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                              *");
            Console.WriteLine("* Выполнил: Комаров Никита Алексеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные, в*");
            Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране. Расчеты: Напи*");
            Console.WriteLine("*исать программу, которая преобразует введенное с клавиатуры дробное число*");
            Console.WriteLine("*о в денежный формат. Ответ округлите до 3 знаков после запятой. Введите д*");
            Console.WriteLine("*дробное число -> 23.6 23.6 руб. — это 23 руб. 60 коп.                    *");
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

            double money = double.Parse(Console.ReadLine());
            double result = ds.NumberToMoney(money);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}