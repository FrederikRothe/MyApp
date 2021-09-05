using System;
using Xunit;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void isDivisbleByFour()
        {
            Assert.True(Program.IsLeapYear(12));
            Assert.True(Program.IsLeapYear(32));


            Assert.False(Program.IsLeapYear(13));
            Assert.False(Program.IsLeapYear(27));
            Assert.False(Program.IsLeapYear(39));
        }

        [Fact]
        public void isNotDivisbleByHundred()
        {
            Assert.False(Program.IsLeapYear(1655));
            Assert.False(Program.IsLeapYear(1267));
            Assert.False(Program.IsLeapYear(1929));

            Assert.False(Program.IsLeapYear(1800));
            Assert.False(Program.IsLeapYear(1700));
        }

         [Fact]
        public void isDivisbleByFourHundred()
        {
            Assert.True(Program.IsLeapYear(1600));
            Assert.True(Program.IsLeapYear(1200));
            Assert.True(Program.IsLeapYear(800));
            Assert.True(Program.IsLeapYear(400));
        }
    }
}
