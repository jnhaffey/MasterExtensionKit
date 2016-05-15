using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Converters;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Converters
{
	[TestClass]
	public class ToProperCaseExtensionsUnitTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof (SourceNullException), "")]
		public void String_Converter_ToProperCase_Null_Exception()
		{
			TestStringData.NULL_STRING.ToProperCase();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceEmptyException),"")]
		public void String_Converter_ToProperCase_Empty_Invalid()
		{
			var actualResult = TestStringData.EMPTY_STRING.ToProperCase();
			Assert.AreEqual(String.Empty, actualResult);
		}

		#endregion

		[TestMethod]
		public void String_Converter_ToProperCase_Valid()
		{
			var actualResults = TestStringData.STRING_PASCAL_STYLE.ToProperCase();
			Assert.AreEqual(TestStringData.STRING_PROPER_STYLE, actualResults);
		}
	}
}