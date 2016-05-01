using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Validations
{
	[TestClass]
	public class IsValidIpAddressExtensionUnitTest
	{
		[TestMethod]
		[ExpectedException(typeof(SourceNullException),"")]
		public void String_Validation_IsValidIpAddress_Null_Exception()
		{
			TestStringData.NULL_STRING.IsValidIpAddress();
		}

		[TestMethod]
		public void String_Validation_IsValidIpAddress_Empty_Invalid()
		{
			Assert.IsFalse(TestStringData.EMPTY_STRING.IsValidIpAddress());
		}

		[TestMethod]
		public void String_Validation_IsValidIpAddress_1_1_1_1_Valid()
		{
			Assert.IsTrue(TestStringData.IP_ADDRESS_1_1_1_1.IsValidIpAddress());
		}

		[TestMethod]
		public void String_Validation_IsValidIpAddress_254_254_254_254_Valid()
		{
			Assert.IsTrue(TestStringData.IP_ADDRESS_254_254_254_254.IsValidIpAddress());
		}

		[TestMethod]
		public void String_Validation_IsValidIpAddress_0_0_0_0_Invalid()
		{
			Assert.IsTrue(TestStringData.IP_ADDRESS_0_0_0_0.IsValidIpAddress());
		}

		[TestMethod]
		public void String_Validation_IsValidIpAddress_255_255_255_255_Invalid()
		{
			Assert.IsTrue(TestStringData.IP_ADDRESS_255_255_255_255.IsValidIpAddress());
		}
	}
}