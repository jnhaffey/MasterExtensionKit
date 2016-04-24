using System;
using MasterExtensionKit.Strings.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Strings.UnitTests.Validations
{
	[TestClass]
	public class IsGuidExtensionUnitTest
	{
		[TestMethod]
		public void IsGuid_True()
		{
			var guidString = Guid.NewGuid().ToString();
			Assert.IsTrue(guidString.IsGuid());
		}

		[TestMethod]
		public void IsGuid_False()
		{
			var notAGuid = Guid.NewGuid().ToString().Replace("-", "$").Substring(0, 5);
			Assert.IsFalse(notAGuid.IsGuid());
		}
	}
}
