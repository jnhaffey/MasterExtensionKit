using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Validations
{
	[TestClass]
	public class IsValidEmailExtensionTests
	{
		#region Default Format

		[TestMethod]
		public void String_Validation_IsValidEmail_Basic_Valid()
		{
			Assert.IsTrue(TestStringData.EMAIL_ADDRESS_STANDARD_VALID.IsValidEmail());
		}

		[TestMethod]
		public void String_Validation_IsValidEmail_Basic_Invalid()
		{
			Assert.IsFalse(TestStringData.EMAIL_ADDRESS_INVALID.IsValidEmail());
		}

		#endregion

		#region Custom Format

		[TestMethod]
		public void String_Validation_IsValidEmail_CustomFormater_Valid()
		{
			Assert.IsTrue(TestStringData.EMAIL_ADDRESS_CUSTOM_VALID.IsValidEmail(TestStringData.EMAIL_CUSTOM_FORMATTER));
		}

		[TestMethod]
		public void String_Validation_IsValidEmail_CustomFormater_Invalid()
		{
			Assert.IsFalse(TestStringData.EMAIL_ADDRESS_INVALID.IsValidEmail(TestStringData.EMAIL_CUSTOM_FORMATTER));
		}

		#endregion

		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof (SourceNullException), "")]
		public void String_Validation_IsValidEmail_Null_Exception()
		{
			TestStringData.NULL_STRING.IsValidEmail();
		}

		[TestMethod]
		public void String_Validation_IsValidEmail_Empty_Invalid()
		{
			Assert.IsFalse(TestStringData.EMPTY_STRING.IsValidEmail());
		}

		#endregion
	}
}