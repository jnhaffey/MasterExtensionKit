using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Functions
{
	[TestClass]
	public class RemoveNonAlphaNumericExtensionUnitTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void String_Function_RemoveNonAlpahNumeric_Null_Exception()
		{
			TestStringData.NULL_STRING.RemoveNonAlphaNumeric();
		}

		[TestMethod]
		public void String_Function_RemoveNonAlpahNumeric_Empty_Valid()
		{
			var actualResult = TestStringData.EMPTY_STRING.RemoveNonAlphaNumeric();
			Assert.AreEqual(String.Empty, actualResult);
		}

		#endregion

		[TestMethod]
		public void String_Function_RemoveNonAlpahNumeric_AlphaNumericSpecial_Result_AlphaNumericOnly_Valid()
		{
			var actualResults = TestStringData.ALPHANUMERICSPECIAL_STRING.RemoveNonAlphaNumeric();
			Assert.AreEqual(TestStringData.ALPHANUMERIC_STIRNG, actualResults);
		}

		[TestMethod]
		public void String_Function_RemoveNonAlpahNumeric_AlphaNumeric_Result_AlphaNumericOnly_Valid()
		{
			var actualResults = TestStringData.ALPHANUMERIC_STIRNG.RemoveNonAlphaNumeric();
			Assert.AreEqual(TestStringData.ALPHANUMERIC_STIRNG, actualResults);
		}

		[TestMethod]
		public void String_Function_RemoveNonAlpahNumeric_NumericSpecial_Result_NumericOnly_Valid()
		{
			var actualResults = TestStringData.NUMERICSPECIAL_STRING.RemoveNonAlphaNumeric();
			Assert.AreEqual(TestStringData.NUMERIC_ONLY_STRING, actualResults);
		}

		[TestMethod]
		public void String_Function_RemoveNonAlpahNumeric_AlphaSpecial_Result_AlphaOnly_Valid()
		{
			var actualResults = TestStringData.ALPHASPECIAL_STRING.RemoveNonAlphaNumeric();
			Assert.AreEqual(TestStringData.ALPHA_ONLY_STRING, actualResults);
		}
	}
}
