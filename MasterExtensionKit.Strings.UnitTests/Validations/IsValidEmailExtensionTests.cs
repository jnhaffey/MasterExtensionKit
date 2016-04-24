using MasterExtensionKit.Strings.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Strings.UnitTests.Validations
{
	[TestClass]
	public class IsValidEmailExtensionTests
	{
		//TESTING DEFAULT FORMAT
		[TestMethod]
		public void IsValidEmail_Basic_True()
		{
			var emailToTest = "johndoe@example.com";
			Assert.IsTrue(emailToTest.IsValidEmail());
		}

		[TestMethod]
		public void IsValidEmail_Basic_False()
		{
			var emailToTest = "john*doe@example.com";
			Assert.IsFalse(emailToTest.IsValidEmail());
		}

		//TESTING ONE CUSTOM FORMAT
		[TestMethod]
		public void IsValidEmail_CustomFormater_True()
		{
			var customFormat = @"^[\w-\._]+@([\w-]+\.)+[\w-]{2,4}$";
			var emailToTest = "john_doe@example.com";
			Assert.IsTrue(emailToTest.IsValidEmail(customFormat));
		}

		[TestMethod]
		public void IsValidEmail_CustomFormater_False()
		{
			var customFormat = @"^[\w-\._]+@([\w-]+\.)+[\w-]{2,4}$";
			var emailToTest = "john*doe@example.com";
			Assert.IsFalse(emailToTest.IsValidEmail(customFormat));
		}
	}
}