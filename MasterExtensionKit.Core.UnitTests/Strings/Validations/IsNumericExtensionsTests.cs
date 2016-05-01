using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Validations
{
	[TestClass]
	public class IsNumericExtensionsTests
	{
		#region Decimal Tests

		[TestMethod]
		public void String_Validation_IsNumeric_Decimal_MaxValue_Valid()
		{
			Assert.IsTrue(TestStringData.DECIMAL_MAX_VALUE.IsNumeric());
		}

		[TestMethod]
		public void String_Validation_IsNumeric_Decimal_ZeroValue_Valid()
		{
			Assert.IsTrue(TestStringData.DECIMAL_ZERO_VALUE.IsNumeric());
		}

		[TestMethod]
		public void String_Validation_IsNumeric_Decimal_MinValue_Valid()
		{
			Assert.IsTrue(TestStringData.DECIMAL_MIN_VALUE.IsNumeric());
		}

		#endregion

		#region Double Tests

		/// <summary>
		///     While this should be true it returns false due to a 'old issue' in the double.tryparse / double.parse
		/// </summary>
		[TestMethod]
		[ExpectedException(typeof(MaximunDoubleLimitException), "The maximum limit of a double was supplied and is unable to parse")]
		public void String_Validation_IsNumeric_Double_MaxValue_Exception()
		{
			Assert.IsTrue(TestStringData.DOUBLE_MIN_VALUE.IsNumeric());
		}

		[TestMethod]
		public void String_Validation_IsNumeric_Double_ZeroValue_Valid()
		{
			Assert.IsTrue(TestStringData.DOUBLE_ZERO_VALUE.IsNumeric());
		}

		/// <summary>
		///     While this should be true it returns false due to a 'old issue' in the double.tryparse / double.parse
		/// </summary>
		[TestMethod]
		[ExpectedException(typeof(MininumDoubleLimitException), "The minimum limit of a double was supplied and is unable to parse")]
		public void String_Validation_IsNumeric_Double_MinValue_Exception()
		{
			Assert.IsTrue(TestStringData.DOUBLE_MAX_VALUE.IsNumeric());
		}

		#endregion

		#region Float Tests

		[TestMethod]
		public void String_Validation_IsNumeric_Float_MaxValue_Valid()
		{
			Assert.IsTrue(TestStringData.FLOAT_MAX_VALUE.IsNumeric());
		}

		[TestMethod]
		public void String_Validation_IsNumeric_Float_ZeroValue_Valid()
		{
			Assert.IsTrue(TestStringData.FLOAT_ZERO_VALUE.IsNumeric());
		}

		[TestMethod]
		public void String_Validation_IsNumeric_Float_MinValue_Valid()
		{
			Assert.IsTrue(TestStringData.FLOAT_MIN_VALUE.IsNumeric());
		}

		#endregion

		#region AlphaNumeric Tests

		[TestMethod]
		public void String_Validation_IsNumeric_AlphaNumeric_Invalid()
		{
			Assert.IsFalse(TestStringData.RANDOM_ALPHANUMERIC_STIRNG.IsNumeric());
		}

		[TestMethod]
		public void String_Validation_IsNumeric_AlphaOnly_Invalid()
		{
			Assert.IsFalse(TestStringData.ALPHA_ONLY_STRING.IsNumeric());
		}

		#endregion

		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof (SourceNullException), "")]
		public void String_Validation_IsNumeric_Null_Exception()
		{
			TestStringData.NULL_STRING.IsNumeric();
		}

		[TestMethod]
		public void String_Validation_IsIsNumeric_Empty_Invalid()
		{
			Assert.IsFalse(TestStringData.EMPTY_STRING.IsNumeric());
		}

		#endregion

		#region Integer Tests

		[TestMethod]
		public void String_Validation_IsNumeric_Integer_MaxValue_Valid()
		{
			Assert.IsTrue(TestStringData.INTEGER_MAX_VALUE.IsNumeric());
		}

		[TestMethod]
		public void String_Validation_IsNumeric_Integer_ZeroValue_Valid()
		{
			Assert.IsTrue(TestStringData.INTEGER_ZERO_VALUE.IsNumeric());
		}

		[TestMethod]
		public void String_Validation_IsNumeric_Integer_MinValue_Valid()
		{
			Assert.IsTrue(TestStringData.INTEGER_MIN_VALUE.IsNumeric());
		}

		#endregion

		#region Long Tests

		[TestMethod]
		public void String_Validation_IsNumeric_Long_MaxValue_Valid()
		{
			Assert.IsTrue(TestStringData.LONG_MAX_VALUE.IsNumeric());
		}

		[TestMethod]
		public void String_Validation_IsNumeric_Long_ZeroValue_Valid()
		{
			Assert.IsTrue(TestStringData.LONG_ZERO_VALUE.IsNumeric());
		}

		[TestMethod]
		public void String_Validation_IsNumeric_Long_MinValue_Valid()
		{
			Assert.IsTrue(TestStringData.LONG_MIN_VALUE.IsNumeric());
		}

		#endregion

		#region Short Tests

		[TestMethod]
		public void String_Validation_IsNumeric_Short_MaxValue_Valid()
		{
			Assert.IsTrue(TestStringData.SHORT_MAX_VALUE.IsNumeric());
		}

		[TestMethod]
		public void String_Validation_IsNumeric_Short_ZeroValue_Valid()
		{
			Assert.IsTrue(TestStringData.SHORT_ZERO_VALUE.IsNumeric());
		}

		[TestMethod]
		public void String_Validation_IsNumeric_Short_MinValue_Valid()
		{
			Assert.IsTrue(TestStringData.SHORT_MIN_VALUE.IsNumeric());
		}

		#endregion
	}
}