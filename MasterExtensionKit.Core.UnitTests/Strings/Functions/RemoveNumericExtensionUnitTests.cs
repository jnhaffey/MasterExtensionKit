using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Functions
{
	[TestClass]
	public class RemoveNumericExtensionUnitTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void String_Function_RemoveNumeric_Null_Exception()
		{
			TestStringData.NULL_STRING.RemoveNumeric();
		}

		[TestMethod]
		public void String_Function_RemoveNumeric_Empty_Valid()
		{
			var actualResult = TestStringData.EMPTY_STRING.RemoveNumeric();
			Assert.AreEqual(String.Empty, actualResult);
		}

		#endregion

		[TestMethod]
		public void String_Function_RemoveNumeric_AlphaNumericSpecial_Result_AlphaSpecialOnly_Valid()
		{
			var actualResults = TestStringData.ALPHANUMERICSPECIAL_STRING.RemoveNumeric();
			Assert.AreEqual(TestStringData.ALPHASPECIAL_STRING, actualResults);
		}

		[TestMethod]
		public void String_Function_RemoveNumeric_AlphaNumeric_Result_AlphaOnly_Valid()
		{
			var actualResults = TestStringData.ALPHANUMERIC_STIRNG.RemoveNumeric();
			Assert.AreEqual(TestStringData.ALPHA_ONLY_STRING, actualResults);
		}

		[TestMethod]
		public void String_Function_RemoveNumeric_NumericSpecial_Result_SpecialOnly_Valid()
		{
			var actualResults = TestStringData.NUMERICSPECIAL_STRING.RemoveNumeric();
			Assert.AreEqual(TestStringData.SPECIAL_ONLY_STRING, actualResults);
		}

		[TestMethod]
		public void String_Function_RemoveNumeric_AlphaSpecial_Result_AlphaSpecialOnly_Valid()
		{
			var actualResults = TestStringData.ALPHASPECIAL_STRING.RemoveNumeric();
			Assert.AreEqual(TestStringData.ALPHASPECIAL_STRING, actualResults);
		}
	}
}
