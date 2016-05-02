using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Validations
{
	[TestClass]
	public class IsGuidExtensionUnitTest
	{
		#region Invalid

		[TestMethod]
		public void String_Validation_IsGuid_Format_Unknown_Invalid()
		{
			var unknownGuidFormat = $"{TestStringData.GUID_B_FORMAT}{TestStringData.GUID_D_FORMAT}";
			Assert.IsFalse(unknownGuidFormat.IsGuid());
		}

		#endregion

		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof (SourceNullException), "")]
		public void String_Validation_IsGuid_Null_Exception()
		{
			TestStringData.NULL_STRING.IsGuid();
		}

		[TestMethod]
		public void String_Validation_IsGuid_Empty_Invalid()
		{
			Assert.IsFalse(TestStringData.EMPTY_STRING.IsGuid());
		}

		#endregion

		#region Guid Formats

		[TestMethod]
		public void String_Validation_IsGuid_Format_B_Valid()
		{
			Assert.IsTrue(TestStringData.GUID_B_FORMAT.IsGuid());
		}

		[TestMethod]
		public void String_Validation_IsGuid_Format_D_Valid()
		{
			Assert.IsTrue(TestStringData.GUID_D_FORMAT.IsGuid());
		}

		[TestMethod]
		public void String_Validation_IsGuid_Format_N_Valid()
		{
			Assert.IsTrue(TestStringData.GUID_N_FORMAT.IsGuid());
		}

		[TestMethod]
		public void String_Validation_IsGuid_Format_P_Valid()
		{
			Assert.IsTrue(TestStringData.GUID_P_FORMAT.IsGuid());
		}

		[TestMethod]
		public void String_Validation_IsGuid_Format_X_Valid()
		{
			Assert.IsTrue(TestStringData.GUID_X_FORMAT.IsGuid());
		}

		#endregion
	}
}