using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Functions
{
	[TestClass]
	public class RemoveAlphaExtensionUnitTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void String_Function_RemoveAlpha_Null_Exception()
		{
			TestStringData.NULL_STRING.RemoveAlpha();
		}

		[TestMethod]
		public void String_Function_RemoveAlpha_Empty_Valid()
		{
			var actualResult = TestStringData.EMPTY_STRING.RemoveAlpha();
			Assert.AreEqual(String.Empty, actualResult);
		}

		#endregion

		[TestMethod]
		public void String_Function_RemoveAlpha_AlphaNumericSpecial_Result_NumericSpecialOnly_Valid()
		{
			var actualResults = TestStringData.ALPHANUMERICSPECIAL_STRING.RemoveAlpha();
			Assert.AreEqual(TestStringData.NUMERICSPECIAL_STRING, actualResults);
		}

		[TestMethod]
		public void String_Function_RemoveAlpha_AlphaNumeric_Result_NumericOnly_Valid()
		{
			var actualResults = TestStringData.ALPHANUMERIC_STIRNG.RemoveAlpha();
			Assert.AreEqual(TestStringData.NUMERIC_ONLY_STRING, actualResults);
		}

		[TestMethod]
		public void String_Function_RemoveAlpha_NumericSpecial_Result_NumericSpecialOnly_Valid()
		{
			var actualResults = TestStringData.NUMERICSPECIAL_STRING.RemoveAlpha();
			Assert.AreEqual(TestStringData.NUMERICSPECIAL_STRING, actualResults);
		}

		[TestMethod]
		public void String_Function_RemoveAlpha_AlphaSpecial_Result_AlphaSpecialOnly_Valid()
		{
			var actualResults = TestStringData.ALPHASPECIAL_STRING.RemoveAlpha();
			Assert.AreEqual(TestStringData.SPECIAL_ONLY_STRING, actualResults);
		}
	}
}
