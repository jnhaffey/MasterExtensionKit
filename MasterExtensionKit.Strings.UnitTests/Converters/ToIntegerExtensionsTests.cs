using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Strings.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Strings.UnitTests.Converters
{
	[TestClass]
	public class ToIntegerExtensionsTests
	{
		[TestMethod]
		public void ToInteger_IgnoreErrorTrue_Zero_Successful()
		{
			var valueToTest = "0";
			var valueExpected = 0;

			var actualValue = valueToTest.ToInteger(true);

			Assert.AreEqual(valueExpected, actualValue);
		}

		[TestMethod]
		public void ToInteger_IgnoreErrorTrue_MaxInteger_Successful()
		{
			var valueToTest = int.MaxValue.ToString();
			var valueExpected = int.MaxValue;

			var actualValue = valueToTest.ToInteger(true);

			Assert.AreEqual(valueExpected, actualValue);
		}

		[TestMethod]
		public void ToInteger_IgnoreErrorTrue_MinimumInteger_Successful()
		{
			var valueToTest = int.MinValue.ToString();
			var valueExpected = int.MinValue;

			var actualValue = valueToTest.ToInteger(true);

			Assert.AreEqual(valueExpected, actualValue);
		}

		[TestMethod]
		public void ToInteger_IgnoreErrorTrue_AlphaOnly_Null()
		{
			var valueToTest = "ABC";
			string valueExpected = null;

			var actualValue = valueToTest.ToInteger(true);

			Assert.AreEqual(valueExpected, actualValue);
		}

		[TestMethod]
		[ExpectedException(typeof (ConversionFailureException), "Failed to convert string to interger.")]
		public void ToInteger_IgnoreErrorFalse_AlphaOnly_Null()
		{
			var valueToTest = "ABC";
			string valueExpected = null;

			var actualValue = valueToTest.ToInteger(false);

			Assert.AreEqual(valueExpected, actualValue);
		}

		[TestMethod]
		public void ToInteger_IgnoreErrorTrue_AlphaNumeric_Null()
		{
			var valueToTest = "123ABC";
			string valueExpected = null;

			var actualValue = valueToTest.ToInteger(true);

			Assert.AreEqual(valueExpected, actualValue);
		}

		[TestMethod]
		[ExpectedException(typeof (ConversionFailureException), "Failed to convert string to interger.")]
		public void ToInteger_IgnoreErrorFalse_AlphaNumeric_Null()
		{
			var valueToTest = "123ABC";
			string valueExpected = null;

			var actualValue = valueToTest.ToInteger(false);

			Assert.AreEqual(valueExpected, actualValue);
		}

		[TestMethod]
		public void ToInteger_IgnoreErrorTrue_Decimal_Null()
		{
			var valueToTest = "12.34";
			string valueExpected = null;

			var actualValue = valueToTest.ToInteger(true);

			Assert.AreEqual(valueExpected, actualValue);
		}

		[TestMethod]
		[ExpectedException(typeof (ConversionFailureException), "Failed to convert string to interger.")]
		public void ToInteger_IgnoreErrorFalse_Decimal_Null()
		{
			var valueToTest = "12.34";
			string valueExpected = null;

			var actualValue = valueToTest.ToInteger(false);

			Assert.AreEqual(valueExpected, actualValue);
		}
	}
}