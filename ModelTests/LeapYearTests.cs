using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace Calendar.Tests
{
	[TestClass]
	public class LeapYearTests
	{
		[TestMethod]
		// MSTests are methods that always beging with public void.
		// Naming convention: NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
		public void IsLeapYear_NumberDivisibleByFour_True()
		{
			LeapYear testLeapYear = new LeapYear();
			Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
		}
		[TestMethod]
		public void IsLeapYear_NumberDivisibleByFour_False()
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
		public void IsLeapYear_MultiplesOfFourHundred_False()
		{
			LeapYear testLeapYear = new LeapYear();
			Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
		}
	}
}