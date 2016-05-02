using System;
using MasterExtensionKit.Core.Datetimes.Functions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Datetimes.Functions
{
	[TestClass]
	public class AgeExtensionsUnitTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Datetime_Function_Age_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Datetime_Function_Age_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion

		[TestMethod]
		public void Datetime_Function_Age_FiveYearsAgoYesterday_Five()
		{
			var dateToTest = TestDateTimeData.TODAY_MINUS_FIVE_YEARS.AddDays(-1);
			const int expectedResult = 5;
			var actualResult = dateToTest.Age();
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		public void Datetime_Function_Age_FiveYearsAgoToday_Five()
		{
			var dateToTest = TestDateTimeData.TODAY_MINUS_FIVE_YEARS;
			const int expectedResult = 5;
			var actualResult = dateToTest.Age();
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		public void Datetime_Function_Age_FiveYearsAgoTomorrow_Four()
		{
			var dateToTest = TestDateTimeData.TODAY_MINUS_FIVE_YEARS.AddDays(+1);
			const int expectedResult = 4;
			var actualResult = dateToTest.Age();
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}