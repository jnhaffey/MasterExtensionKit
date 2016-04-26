using MasterExtensionKit.Core.Strings.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Validations
{
	[TestClass]
	public class IsValidIpAddressExtensionUnitTest
	{
		[TestMethod]
		public void IsValidIpAddress_1_1_1_1_True()
		{
			var ipStringToTest = "1.1.1.1";
			Assert.IsTrue(ipStringToTest.IsValidIPAddress());
		}

		[TestMethod]
		public void IsValidIpAddress_254_254_254_254_True()
		{
			var ipStringToTest = "254.254.254.254";
			Assert.IsTrue(ipStringToTest.IsValidIPAddress());
		}

		[TestMethod]
		public void IsValidIpAddress_0_0_0_0_False()
		{
			var ipStringToTest = "0.0.0.0";
			Assert.IsTrue(ipStringToTest.IsValidIPAddress());
		}

		[TestMethod]
		public void IsValidIpAddress_255_255_255_255_False()
		{
			var ipStringToTest = "255.255.255.255";
			Assert.IsTrue(ipStringToTest.IsValidIPAddress());
		}
	}
}