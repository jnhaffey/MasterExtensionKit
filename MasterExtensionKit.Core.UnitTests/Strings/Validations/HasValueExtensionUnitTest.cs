using MasterExtensionKit.Core.Strings.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Validations
{
	[TestClass]
	public class HasValueExtensionUnitTest
	{
		[TestMethod]
		public void String_Validation_HasValue_Valid()
		{
			Assert.IsTrue(TestStringData.ALPHANUMERIC_STIRNG.HasValue());
		}

		[TestMethod]
		public void String_Validation_HasValue_WhiteSpace_Invalid()
		{
			Assert.IsFalse(TestStringData.WHITESPACE_STRING.HasValue());
		}

		#region General Tests

		[TestMethod]
		public void String_Validation_HasValue_Null_Invalid()
		{
			Assert.IsFalse(TestStringData.NULL_STRING.HasValue());
		}

		[TestMethod]
		public void String_Validation_HasValue_Empty_Invalid()
		{
			Assert.IsFalse(TestStringData.EMPTY_STRING.HasValue());
		}

		#endregion
	}
}