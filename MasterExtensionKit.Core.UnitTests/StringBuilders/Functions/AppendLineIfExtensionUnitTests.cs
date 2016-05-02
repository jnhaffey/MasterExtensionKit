using System;
using MasterExtensionKit.Core.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.StringBuilders.Functions
{
	[TestClass]
	public class AppendLineIfExtensionUnitTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void StringBuilder_Function_AppendLineIf_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void StringBuilder_Function_AppendLineIf_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion

		[TestMethod]
		public void StringBuilder_Function_AppendLineIf_Test()
		{
			Assert.Fail("NOT IMPLEMENTED");
		}
	}
}
