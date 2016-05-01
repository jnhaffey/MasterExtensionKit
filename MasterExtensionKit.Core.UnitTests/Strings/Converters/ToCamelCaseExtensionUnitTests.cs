using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Converters;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Converters
{
	public class ToCamelCaseExtensionUnitTests
	{
		[TestMethod]
		public void String_Converter_ToCamelCase_Valid()
		{
			var actualResults = TestStringData.STRING_PROPER_STYLE.ToCamelCase();
			Assert.AreEqual(TestStringData.STRING_CAMEL_STYLE, actualResults);
		}

		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof (SourceNullException), "")]
		public void String_Converter_ToCamelCase_Null_Exception()
		{
		}

		[TestMethod]
		[ExpectedException(typeof (SourceNullException), "")]
		public void String_Converter_ToCamelCase_Empty_Invalid()
		{
		}

		#endregion
	}
}