using System;
using MasterExtensionKit.Core.Datetimes.Functions;
using MasterExtensionKit.Core.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Datetimes.Functions
{
	public class StartOfWeekExtensionUnitTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Datetime_Function_StartOfWeek_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Datetime_Function_StartOfWeek_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion

		[TestMethod]
		public void Datetime_Function_StartOfWeek_2000_1_1_Monday()
		{
			var dateToTest = new DateTime(2000, 1, 1);
			var expectedResult = new DateTime(1999, 12, 27);
			Assert.AreEqual(expectedResult, dateToTest.StartOfWeek(DayOfWeek.Monday));
		}

		[TestMethod]
		public void Datetime_Function_StartOfWeek_2001_1_1_Sunday()
		{
			var dateToTest = new DateTime(2001, 1, 1);
			var expectedResult = new DateTime(2000, 12, 31);
			Assert.AreEqual(expectedResult, dateToTest.StartOfWeek(DayOfWeek.Sunday));
		}
	}
}