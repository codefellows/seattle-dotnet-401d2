using DemoDay2;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //[Fact]
        //public void CanReturn1()
        //{
        //    Xunit.Assert.Equal("1", FizzBuzz.Convert(1));
        //}

        //[Fact]
        //public void CanReturn2()
        //{
        //    Xunit.Assert.Equal("2", FizzBuzz.Convert(2));

        //}

        [Fact]
        public void CanReturnFizzfor3()
        {
            Assert.Equal("Fizz", FizzBuzz.Convert(3));
        }

        [Fact]
        public void CanReturnBuzzFor5()
        {
            Assert.Equal("Buzz", FizzBuzz.Convert(5));
        }

        //[Fact]
        //public void CanReturn4()
        //{
        //    Xunit.Assert.Equal("4", FizzBuzz.Convert(4));

        //}

        [Theory]
        [InlineData(1,"1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]

        public void CanReturnNumber(int value, string expectedValue)
        {
            Xunit.Assert.Equal(expectedValue, FizzBuzz.Convert(value));

        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void ReturnFizz(int n)
        {
            Assert.Equal("Fizz", FizzBuzz.Convert(n));
        }


        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void ReturnBuzz(int n)
        {
            Assert.Equal("Buzz", FizzBuzz.Convert(n));
        }


        [Theory]
        [InlineData(15)]
        [InlineData(90)]
        [InlineData(900)]
        [InlineData(-15)]
        [InlineData(0)]


        public void ReturnFizzBuzz(int n)
        {
            Assert.Equal("FizzBuzz", FizzBuzz.Convert(n));
        }




    }
}
