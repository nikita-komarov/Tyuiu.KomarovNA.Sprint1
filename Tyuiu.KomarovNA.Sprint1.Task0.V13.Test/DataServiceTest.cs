using Tyuiu.KomarovNA.Sprint1.Task0.V13.Lib;

namespace Tyuiu.KomarovNA.Sprint1.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int answer = 24 / (6 * 2) - 24 / 6 / 4;
            int result = DataService.CalcExpression(24, 6, 2, 24, 6, 4);
            Assert.AreEqual(answer, result);
        }
    }
}