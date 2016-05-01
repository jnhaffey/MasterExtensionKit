using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Functions
{
	[TestClass]
	public class GetWordCountExtensionUnitTests
	{
		[TestMethod]
		public void String_Function_GetWordCount_Expecting_Nine()
		{
			var actualResult = TestStringData.STRING_PROPER_STYLE.GetWordCount();
			Assert.AreEqual(9, actualResult);
		}

		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof (SourceNullException), "")]
		public void String_Function_GetWordCount_Null_Exception()
		{
			TestStringData.NULL_STRING.GetWordCount();
		}

		[TestMethod]
		public void String_Function_GetWordCount_Empty_Expecting_None()
		{
			TestStringData.EMPTY_STRING.GetWordCount();
		}

		#endregion
	}
}