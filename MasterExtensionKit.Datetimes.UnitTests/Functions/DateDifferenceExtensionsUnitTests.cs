using System;
using MasterExtensionKit.Datetimes.Functions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Datetimes.UnitTests.Functions
{
	[TestClass]
	public class DateDifferenceExtensionsUnitTests
	{
		#region Age Tests

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

		#endregion
	}
}