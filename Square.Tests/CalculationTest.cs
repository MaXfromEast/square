using Calculation;
namespace Square.Tests
{
    [TestClass]
    public class CalculationTest
    {
        [TestMethod]
        public void Mult5and5andPi_78point5Result()
        {
            double r = 5;
            double expected = Math.Round(Figures.Circle.CalcCircleSq(r), 1);
            double actual = 78.5;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AandBandC_Resuld18()
        {
            double a = 6;
            double b = 6;
            double c = 8.485;
            double expcted = Math.Round(Figures.Triangle.CalcTriangleSq(a,b,c), 0);
            double actual = 18;
            Assert.AreEqual(expcted, actual);
        }
            

    }
}