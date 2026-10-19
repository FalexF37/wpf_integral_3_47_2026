using WPF_Integral.Classes;

namespace WPF_Integral.Tests
{
    public class RectangleCalculatorTest
    {
        [Fact]
        public void Rectange_XX_Return_Correct_Answer()
        {
            //Arrange (Подготовка)
            double upperLimit = 100;
            double lowerLimit = 0;
            int count = 1000000;
            Func<double, double> integralFunction = x => x * x;

            double expectedResult = 333333.3333;

            //Act (Действия)
            RectangleCalculator calculator = new RectangleCalculator();
            double actualResult = calculator.Integrate(lowerLimit, upperLimit, count, integralFunction);

            //Assert (Сравнение)
            Assert.Equal(expectedResult, actualResult, 0.01);
        }
        [Fact]
        public void Rectange_X1_Return_Correct_Answer()
        {
            //Arrange (Подготовка)
            double upperLimit = 10;
            double lowerLimit = 0;
            int count = 1000000;
            Func<double, double> integralFunction = x => x * x;

            double expectedResult = 333.3333;

            //Act (Действия)
            RectangleCalculator calculator = new RectangleCalculator();
            double actualResult = calculator.Integrate(lowerLimit, upperLimit, count, integralFunction);

            //Assert (Сравнение)
            Assert.Equal(expectedResult, actualResult, 0.01);
        }
        
        [Fact]
        public void Rectange_Count_Negative_Return_Correct_Answer()
        {
            //Arrange (Подготовка)
            double upperLimit = 100;
            double lowerLimit = 0;
            int count = -1000;
            Func<double, double> integralFunction = x => x * x;

            double expectedResult = 333333.3333;

            //Act (Действия)
            RectangleCalculator calculator = new RectangleCalculator();
            

            //Assert (Сравнение)
            Assert.Throws<ArgumentException>(() => calculator.Integrate(lowerLimit, upperLimit, count, integralFunction));
        }

    }
}

