using System;
using MasterExtensionKit.Core.Datetimes.Functions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Datetimes.Functions
{
	[TestClass]
	public class AgeExtensionsUnitTests
	{
		private readonly AgeExtensionUnitTests _ageExtensionUnitTests = new AgeExtensionUnitTests();
		private DateTime _baseDate = DateTime.Now.AddYears(-5);

		[TestMethod]
		public void Age_FiveYearsAgoYesterday_Five()
		{
			var dateToTest = _baseDate.AddDays(-1);
			const int expectedResult = 5;
			var actualResult = dateToTest.Age();
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		public void Age_FiveYearsAgoToday_Five()
		{
			var dateToTest = _baseDate;
			const int expectedResult = 5;
			var actualResult = dateToTest.Age();
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		public void Age_FiveYearsAgoTomorrow_Four()
		{
			var dateToTest = _baseDate.AddDays(+1);
			const int expectedResult = 4;
			var actualResult = dateToTest.Age();
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}