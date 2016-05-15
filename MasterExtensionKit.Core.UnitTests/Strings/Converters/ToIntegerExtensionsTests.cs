using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Converters;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Converters
{
	[TestClass]
	public class ToIntegerExtensionsTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void String_Converter_ToInteger_Null_Exception()
		{
			TestStringData.NULL_STRING.ToInteger();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceEmptyException), "")]
		public void String_Converter_ToInteger_Empty_Invalid()
		{
			TestStringData.EMPTY_STRING.ToInteger();
		}

		#endregion

		[TestMethod]
		public void String_Converter_ToInteger_IgnoreErrorTrue_Zero_Valid()
		{
			Assert.AreEqual(TestNumberData.INTEGER_ZERO, TestStringData.INTEGER_ZERO_VALUE.ToInteger());
		}

		[TestMethod]
		public void String_Converter_ToInteger_IgnoreErrorTrue_MaxInteger_Valid()
		{
			Assert.AreEqual(TestNumberData.INTEGER_MAX_VALUE, TestStringData.INTEGER_MAX_VALUE.ToInteger());
		}

		[TestMethod]
		public void String_Converter_ToInteger_IgnoreErrorTrue_MinimumInteger_Valid()
		{
			Assert.AreEqual(TestNumberData.INTEGER_MIN_VALUE, TestStringData.INTEGER_MIN_VALUE.ToInteger());
		}

		[TestMethod]
		public void String_Converter_ToInteger_IgnoreErrorTrue_AlphaOnly_Null()
		{
			Assert.AreEqual(TestNumberData.INTEGER_NULL, TestStringData.ALPHA_ONLY_STRING.ToInteger());
		}

		[TestMethod]
		[ExpectedException(typeof (ConversionFailureException), "Failed to convert string to interger.")]
		public void String_Converter_ToInteger_IgnoreErrorFalse_AlphaOnly_Exception()
		{
			Assert.AreEqual(TestNumberData.INTEGER_NULL, TestStringData.ALPHA_ONLY_STRING.ToInteger(false));
		}

		[TestMethod]
		public void String_Converter_ToInteger_IgnoreErrorTrue_AlphaNumeric_Null()
		{
			Assert.AreEqual(TestNumberData.INTEGER_NULL, TestStringData.ALPHANUMERIC_STIRNG.ToInteger());
		}

		[TestMethod]
		[ExpectedException(typeof (ConversionFailureException), "Failed to convert string to interger.")]
		public void String_Converter_ToInteger_IgnoreErrorFalse_AlphaNumeric_Null()
		{
			Assert.AreEqual(TestNumberData.INTEGER_NULL, TestStringData.ALPHANUMERIC_STIRNG.ToInteger(false));
		}

		[TestMethod]
		public void String_Converter_ToInteger_IgnoreErrorTrue_Decimal_Null()
		{
			Assert.AreEqual(TestNumberData.INTEGER_NULL, TestStringData.DECIMAL_MIN_VALUE.ToInteger());
		}

		[TestMethod]
		[ExpectedException(typeof (ConversionFailureException), "Failed to convert string to interger.")]
		public void String_Converter_ToInteger_IgnoreErrorFalse_Decimal_Null()
		{
			Assert.AreEqual(TestNumberData.INTEGER_NULL, TestStringData.DECIMAL_MIN_VALUE.ToInteger(false));
		}
	}
}