using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KomarovNA.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public double NumberToMoney(double number)
        {
            double roundedNumber = Math.Round(number, 2);
            int rubles = (int)roundedNumber;
            int kopecks = (int)((roundedNumber - rubles) * 100);

            return (double)(rubles+(((double)kopecks)/100));
        }
    }
}