namespace Tyuiu.KomarovNA.Sprint1.Task0.V13.Lib
{
    public class DataService
    {
        public static int CalcExpression(int a, int b, int c, int d, int e, int f)
        {
            int result = a / (b * c) - d / e / f;
            return result;
        }
    }
}
