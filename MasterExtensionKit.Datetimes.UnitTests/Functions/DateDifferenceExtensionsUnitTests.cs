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

		#region StartOfWeek Tests

		[TestMethod]
		public void StartOfWeek_2000_1_1_Monday()
		{
			var dateToTest = new DateTime(2000,1,1);
			var expectedResult = new DateTime(1999,12,27);
			Assert.AreEqual(expectedResult, dateToTest.StartOfWeek(DayOfWeek.Monday));
		}

		[TestMethod]
		public void StartOfWeek_2001_1_1_Sunday()
		{
			var dateToTest = new DateTime(2001,1,1);
			var expectedResult = new DateTime(2000,12,31);
			Assert.AreEqual(expectedResult, dateToTest.StartOfWeek(DayOfWeek.Sunday));
		}
		#endregion
	}
}