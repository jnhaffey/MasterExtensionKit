using System;
using MasterExtensionKit.Datetimes.Functions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Datetimes.UnitTests.Functions
{
	public class AgeExtensionUnitTests
	{
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
	}
}