using WPF_Integral.Classes;

namespace WPF_Integral.Tests
{
    public class TrapezoidCalculatorTest
    {
        [Fact]
        public void Trapezoid_XX_Return_Correct_Answer()
        {
            //Arrange (Подготовка)
            double upperLimit = 100;
            double lowerLimit = 0;
            int count = 1000000;
            Func<double, double> integralFunction = x => x * x;

            double expectedResult = 333333.3333;

            //Act (Действия)
            TrapezoidCalculator calculator = new TrapezoidCalculator();
            double actualResult = calculator.Integrate(lowerLimit, upperLimit, count, integralFunction);

            //Assert (Сравнение)
            Assert.Equal(expectedResult, actualResult, 0.01);
        }
    }
}