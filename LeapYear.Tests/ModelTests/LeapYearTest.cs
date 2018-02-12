using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeapYear;

namespace LeapYear.Tests
{
    [TestClass]
    public class LeapYearTest
    {
        [TestMethod]
        public void IsLeapYear_NumberDivisbleByFour_True()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
        }

        [TestMethod]
        public void IsLeapYear_NumberNotDivisbleByFour_False()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
        }

        [TestMethod]
        public void IsLeapYear_MultiplesOfOneHundred_False()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
        }

        [TestMethod]
        public void IsLeapYear_MultiplesOfFourHundred_True()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
        }
    }
}
