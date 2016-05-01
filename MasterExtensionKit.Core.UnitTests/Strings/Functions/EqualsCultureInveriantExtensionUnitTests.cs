using System.Globalization;
using MasterExtensionKit.Core.Strings.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Functions
{
	[TestClass]
	public class EqualsCultureInveriantExtensionUnitTests
	{
		[TestMethod]
		public void String_Function_EqualsCultureInveriant_Valid()
		{
			Assert.IsTrue(TestStringData.STRING_PROPER_STYLE.EqualsCultureInveriant(TestStringData.STRING_PROPER_STYLE));
		}

		[TestMethod]
		public void String_Function_EqualsCultureInveriant_Invalid()
		{
			Assert.IsFalse(TestStringData.STRING_PROPER_STYLE.EqualsCultureInveriant(TestStringData.STRING_CAMEL_STYLE));
		}

		[TestMethod]
		public void String_Function_EqualsCultureInveriant_GB_US_Valid()
		{
			var gbString = string.Format(new CultureInfo("en-GB"), "{0}", TestStringData.STRING_PROPER_STYLE);
			var usString = string.Format(new CultureInfo("en-US"), "{0}", TestStringData.STRING_PROPER_STYLE);
			Assert.IsTrue(gbString.EqualsCultureInveriant(usString));
		}

		#region General String Tests

		[TestMethod]
		public void String_Function_EqualsCultureInveriant_Null_Invalid()
		{
			Assert.IsFalse(TestStringData.NULL_STRING.EqualsCultureInveriant(TestStringData.NULL_STRING));
		}

		[TestMethod]
		public void String_Function_EqualsCultureInveriant_Empty_Invalid()
		{
			Assert.IsFalse(TestStringData.EMPTY_STRING.EqualsCultureInveriant(TestStringData.EMPTY_STRING));
		}

		#endregion
	}
}