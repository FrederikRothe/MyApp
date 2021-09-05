using System;
using Xunit;
using System.IO;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsLeapYear_isDivisbleByFour()
        {
            Assert.False(Program.IsLeapYear(11));
            Assert.False(Program.IsLeapYear(17));
            Assert.False(Program.IsLeapYear(13));
            Assert.False(Program.IsLeapYear(27));
            Assert.False(Program.IsLeapYear(39));
        }

        [Fact]
        public void IsLeapYear_isNotDivisbleByHundred()
        {
            Assert.False(Program.IsLeapYear(1655));
            Assert.False(Program.IsLeapYear(1267));
            Assert.False(Program.IsLeapYear(1929));
            Assert.False(Program.IsLeapYear(1800));
            Assert.False(Program.IsLeapYear(1700));
        }

         [Fact]
        public void IsLeapYear_isDivisbleByFourHundred()
        {
            Assert.True(Program.IsLeapYear(1600));
            Assert.True(Program.IsLeapYear(2000));
            Assert.False(Program.IsLeapYear(1200));
            Assert.False(Program.IsLeapYear(800));
            Assert.False(Program.IsLeapYear(400));
        }
    }
}
