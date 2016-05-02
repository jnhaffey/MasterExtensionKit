using System;
using MasterExtensionKit.Core.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Collections.Functions
{
	[TestClass]
	public class PageExtensionUnitTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Collection_Function_Page_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Collection_Function_Page_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion

		[TestMethod]
		public void Collection_Function_Page_Test()
		{
			Assert.Fail("NOT IMPLEMENTED");
		}
	}
}
