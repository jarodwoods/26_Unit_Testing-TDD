using System;
using System.Linq;
using UnitTestingExercise;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(-1,1,0,0)]
        [InlineData(1, 1, 1, 3)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-1, -1, -1, -3)]
        public void AddTester(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var add = new UnitTestMethods();
            //Act
            var actual = add.Add(num1, num2, num3);
            //Assert
            Assert.Equal(actual, expected);
            

        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(1, 0, 1)]
        [InlineData(0, 1, -1)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var sub = new UnitTestMethods();
            //Act
            var actual = sub.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(0, 1, 0)]
        [InlineData(-1, 1, -1)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var mult = new UnitTestMethods();
            //Act
            var actual = mult.Multiply(num1, num2);
            //Assert
            Assert.Equal(actual, expected);

        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(0, 1, 0)]
        [InlineData(11, 0, 0)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var div = new UnitTestMethods();
            //Act
            var actual = div.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }


        [Fact]
        public void ReturnHelloWorld()
        {
            //Arrange
            var returnHW = new UnitTestMethods();
            string answer = "Hello, World!";

            //Act
            var actual = returnHW.ReturnHelloWorld();

            //Assert
            Assert.Equal(answer, actual);
        }

        [Fact]
        public void EvenNumbersFrom_0_100()
        {
            //Arrange
            var divN = new UnitTestMethods();
            int[] evens = new int[] 
            { 
                 0, 2, 4, 6, 8, 10,
                12, 14, 16, 18, 20,
                22, 24, 26, 28, 30,
                32, 34, 36, 38, 40,
                42, 44, 46, 48, 50,
                52, 54, 56, 58, 60,
                62, 64, 66, 68, 70, 
                72, 74, 76, 78, 80, 
                82, 84, 86, 88, 90,
                92, 94, 96, 98, 100 
            };

            //Act
            var actual = divN.EvenNumbersFrom_0_100();

            //Assert
            Assert.Equal(actual, evens);
        }

        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1,2 }, 3)]
        [InlineData(new int[] { 1,2,3 }, 6)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 55)]
        [InlineData(new int[] { -1 }, -1)]
        [InlineData(new int[] { -1,-2 }, -3)]
        [InlineData(new int[] { -1,-2,-3 }, -6)]
        [InlineData(new int[] { 1, -1 }, 0)]
        [InlineData(new int[] { }, 0)]
        //[InlineData(null, 0)]
        public void Add(int[] arr, int expected)
        {
            //Arrange
            var add = new UnitTestMethods();

            //Act
            int x = 0;
            var actual = add.Add(x, expected);

            //Assert
            Assert.Equal(actual, expected);
        }


    }
}
