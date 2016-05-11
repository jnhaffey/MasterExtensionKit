using System;
using MasterExtensionKit.Core.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Collections.Functions
{
	[TestClass]
	public class DistinctByExtensionUnitTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Collection_Function_DistinctBy_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Collection_Function_DistinctBy_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion
	}
}
