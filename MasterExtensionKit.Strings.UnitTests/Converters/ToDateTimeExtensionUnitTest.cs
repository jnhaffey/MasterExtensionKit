using System;
using MasterExtensionKit.Strings.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Strings.UnitTests.Converters
{
	[TestClass]
	public class ToDateTimeExtensionUnitTest
	{
		[TestMethod]
		public void ToDateTime_ValidString_True()
		{
			var expectedResults = new DateTime(2010, 1, 1);
			var stringToTest = "1/1/2010";
			var actualResults = stringToTest.ToDateTime();

			Assert.IsInstanceOfType(actualResults,typeof(DateTime));
			Assert.AreEqual(expectedResults, actualResults);
		}

		[TestMethod]
		public void ToDateTime_InvalidString_False()
		{
			DateTime? expectedResults = new DateTime?();
			var stringToTest = "1/1/20AA";
			var actualResults = stringToTest.ToDateTime();

			Assert.AreEqual(expectedResults, actualResults);
		}
	}
}
