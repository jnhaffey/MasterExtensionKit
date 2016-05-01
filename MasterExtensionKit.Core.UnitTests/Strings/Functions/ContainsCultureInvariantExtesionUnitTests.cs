using System.Globalization;
using MasterExtensionKit.Core.Strings.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Functions
{
	[TestClass]
	public class ContainsCultureInvariantExtesionUnitTests
	{
		[TestMethod]
		public void String_Function_ContainsCultureInveriant_Valid()
		{
			Assert.IsTrue(TestStringData.STRING_PROPER_STYLE.ContainsCultureInvariant(TestStringData.STRING_PROPER_STYLE));
		}

		[TestMethod]
		public void String_Function_ContainsCultureInveriant_Invalid()
		{
			Assert.IsFalse(TestStringData.STRING_PROPER_STYLE.ContainsCultureInvariant(TestStringData.STRING_CAMEL_STYLE));
		}

		[TestMethod]
		public void String_Function_ContainsCultureInveriant_GB_US_Valid()
		{
			var gbString = string.Format(new CultureInfo("en-GB"), "{0}", TestStringData.STRING_PROPER_STYLE);
			var usString = string.Format(new CultureInfo("en-US"), "{0}", TestStringData.STRING_PROPER_STYLE);
			Assert.IsTrue(gbString.ContainsCultureInvariant(usString));
		}

		#region General String Tests

		[TestMethod]
		public void String_Function_ContainsCultureInveriant_Null_Invalid()
		{
			Assert.IsFalse(TestStringData.NULL_STRING.ContainsCultureInvariant(TestStringData.NULL_STRING));
		}

		[TestMethod]
		public void String_Function_ContainsCultureInveriant_Empty_Invalid()
		{
			Assert.IsFalse(TestStringData.EMPTY_STRING.ContainsCultureInvariant(TestStringData.EMPTY_STRING));
		}

		#endregion
	}
}