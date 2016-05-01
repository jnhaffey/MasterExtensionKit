using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Converters;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Converters
{
	public class ToPascalCaseExtensionUnitTests
	{
		[TestMethod]
		public void String_Converter_ToPascalCase_Valid()
		{
			var actualResults = TestStringData.STRING_PROPER_STYLE.ToPascalCase();
			Assert.AreEqual(TestStringData.STRING_PASCAL_STYLE, actualResults);
		}

		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof (SourceNullException), "")]
		public void String_Converter_ToPascalCase_Null_Exception()
		{
		}

		[TestMethod]
		[ExpectedException(typeof (SourceNullException), "")]
		public void String_Converter_ToPascalCase_Empty_Invalid()
		{
		}

		#endregion
	}
}