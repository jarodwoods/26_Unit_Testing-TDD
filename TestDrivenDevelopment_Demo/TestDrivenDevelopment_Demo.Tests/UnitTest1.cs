using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Xunit.Sdk;
using TestDrivenDevelopment_Demo;

namespace TestDrivenDevelopment_Demo.Tests
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(0,0,0)]
        [InlineData(-35, 25, -10)]
        [InlineData(110, -77, 33)]
        [InlineData(-11, -15, -26)]        
        public void EachElementHasOver4_Chars(int x, int y, int expected)
        {
            //Arrange
            Methods m = new Methods();

            //Act
            var actual = m.Add(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckDivideByZero()
        {
            //Arrange 
            var methods = new Methods();

            //Act
            var actual = methods.Divide(11, 0);

            //Assert
            Assert.Equal(1, actual);
        }
    }
}
