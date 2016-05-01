using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Converters;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Converters
{
	[TestClass]
	public class FromBase64ExtensionUnitTests
	{
		[TestMethod]
		public void String_Converter_ToBase64_Valid()
		{
			Assert.AreEqual(TestStringData.STRING_PROPER_STYLE, TestStringData.BASE64_STRING.FromBase64());
		}

		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void String_Converter_ToBase64_Null_Exception()
		{
			TestStringData.NULL_STRING.FromBase64();
		}

		[TestMethod]
		public void String_Converter_ToBase64_Empty_Invalid()
		{
			Assert.AreEqual(TestStringData.EMPTY_STRING,TestStringData.EMPTY_STRING.FromBase64());
		}

		#endregion
	}
}
