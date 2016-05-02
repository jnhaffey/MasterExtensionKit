using System;
using System.Text;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.StringBuilders.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.StringBuilders.Functions
{
	[TestClass]
	public class AppendIfExtensionUnitTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void StringBuilder_Function_To_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void StringBuilder_Function_To_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion

		[TestMethod]
		public void StringBuilder_Function_AppendIf_DoubleSameString()
		{
			const string expectedResults = TestStringData.STRING_PROPER_STYLE + TestStringData.STRING_PROPER_STYLE;
			var stringBuilder = new StringBuilder(TestStringData.STRING_PROPER_STYLE);
			stringBuilder.AppendIf(true, TestStringData.STRING_PROPER_STYLE);
			Assert.AreEqual(expectedResults, stringBuilder.ToString());
		}
	}
}
