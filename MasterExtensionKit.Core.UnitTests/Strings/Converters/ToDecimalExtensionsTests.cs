using System.IO;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Converters;
using MasterExtensionKit.Core.Strings.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Converters
{
	[TestClass]
	public class ToDecimalExtensionsTests
	{
		[TestMethod]
		public void String_Converter_ToDecimal_IgnoreErrorTrue_Zero_Valid()
		{
			Assert.AreEqual(TestNumberData.DECIMAL_ZERO, TestStringData.DECIMAL_ZERO_VALUE.ToDecimal());
		}

		[TestMethod]
		public void String_Converter_ToDecimal_IgnoreErrorTrue_MaxDecimal_Valid()
		{
			Assert.AreEqual(TestNumberData.DECIMAL_MAX_VALUE, TestStringData.DECIMAL_MAX_VALUE.ToDecimal());
		}

		[TestMethod]
		public void String_Converter_ToDecimal_IgnoreErrorTrue_MinDecimal_Valid()
		{
			Assert.AreEqual(TestNumberData.DECIMAL_MIN_VALUE, TestStringData.DECIMAL_MIN_VALUE.ToDecimal());
		}

		[TestMethod]
		public void String_Converter_ToDecimal_IgnoreErrorTrue_AlphaOnly_Null()
		{
			Assert.AreEqual(TestNumberData.DECIMAL_NULL, TestStringData.ALPHA_ONLY_STRING.ToDecimal());
		}

		[TestMethod]
		[ExpectedException(typeof(ConversionFailureException), "Failed to convert string to interger.")]
		public void String_Converter_ToDecimal_IgnoreErrorFalse_AlphaOnly_Exception()
		{
			Assert.AreEqual(TestNumberData.DECIMAL_NULL, TestStringData.ALPHA_ONLY_STRING.ToDecimal(false));
		}

		[TestMethod]
		public void String_Converter_ToDecimal_IgnoreErrorTrue_AlphaNumeric_Null()
		{
			Assert.AreEqual(TestNumberData.DECIMAL_NULL, TestStringData.RANDOM_ALPHANUMERIC_STIRNG.ToDecimal());
		}

		[TestMethod]
		[ExpectedException(typeof(ConversionFailureException), "Failed to convert string to interger.")]
		public void String_Converter_ToDecimal_IgnoreErrorFalse_AlphaNumeric_Null()
		{
			Assert.AreEqual(TestNumberData.DECIMAL_NULL, TestStringData.RANDOM_ALPHANUMERIC_STIRNG.ToDecimal(false));
		}

		[TestMethod]
		public void String_Converter_ToDecimal_IgnoreErrorTrue_Integer_IntegerMin()
		{
			Assert.AreEqual(TestNumberData.INTEGER_MIN_VALUE, TestStringData.INTEGER_MIN_VALUE.ToDecimal());
		}

		[TestMethod]
		public void String_Converter_ToDecimal_IgnoreErrorFalse_Integer_IntegerMax()
		{
			Assert.AreEqual(TestNumberData.INTEGER_MAX_VALUE, TestStringData.INTEGER_MAX_VALUE.ToDecimal(false));
		}
	}
}