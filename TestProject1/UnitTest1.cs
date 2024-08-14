using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestDivide()
        {
            var result = Logics.Divide(10, 5);
            Assert.Equal(2, result);
        }
        [Fact]
        public void TestDivide2()
        {
            var result = Logics.Divide(1, 3);
            Assert.Equal(0.333M, result, 3);
        }
        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(1, 3, 0.333)]
        public void TestDivide3(decimal numerator, decimal denominator, decimal expected)
        {
            var result = Logics.Divide(numerator, denominator);
            Assert.Equal(expected, result, 3);
        }
        [Fact]
        public void TestDivideByZero()
        {
            decimal result;
            Assert.Throws<DivideByZeroException>(()=> result = Logics.Divide(1, 0));
        }
        [Fact]
        public void EvenNumberTest()
        {
            //Arrange
            var num = 5;
            //Act
            bool result = num % 2 == 0;
            //Assert
            Assert.True(result);
        }
    }
}