using System;
using MasterExtensionKit.Strings.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Strings.UnitTests.Validations
{
	[TestClass]
	public class HasValueExtensionUnitTest
	{
		[TestMethod]
		public void HasValue_True()
		{
			var stringToTest = "I have Value";
			Assert.IsTrue(stringToTest.HasValue());
		}

		[TestMethod]
		public void HasValue_Empty_False()
		{
			var stringToTest = String.Empty;
			Assert.IsFalse(stringToTest.HasValue());
		}

		[TestMethod]
		public void HasValue_Null_False()
		{
			string stringToTest = null;
			Assert.IsFalse(stringToTest.HasValue());
		}

		[TestMethod]
		public void HasValue_WhiteSpace_False()
		{
			var stringToTest = " ";
			Assert.IsFalse(stringToTest.HasValue());
		}
	}
}
