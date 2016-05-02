using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Converters
{
	[TestClass]
	public class ToDateTimeExtensionUnitTest
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void String_Converter_ToDateTime_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void String_Converter_ToDateTime_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion

		[TestMethod]
		public void String_Converter_ToDateTime_ValidString_True()
		{
			var expectedResults = new DateTime(2010, 1, 1);
			var stringToTest = "1/1/2010";
			var actualResults = stringToTest.ToDateTime();

			Assert.IsInstanceOfType(actualResults, typeof (DateTime));
			Assert.AreEqual(expectedResults, actualResults);
		}

		[TestMethod]
		public void String_Converter_ToDateTime_InvalidString_False()
		{
			var expectedResults = new DateTime?();
			var stringToTest = "1/1/20AA";
			var actualResults = stringToTest.ToDateTime();

			Assert.AreEqual(expectedResults, actualResults);
		}
	}
}