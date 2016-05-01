using System;
using MasterExtensionKit.Core.Objects.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Objects.Validations
{
	[TestClass]
	public class IsNullExtensionUnitTests
	{
		private Object _nullObject;
		private readonly Object _emptyObject = new object();

		[TestMethod]
		public void IsNull_True()
		{
			Assert.IsTrue(_nullObject.IsNull());
		}

		[TestMethod]
		public void IsNull_False()
		{
			Assert.IsFalse(_emptyObject.IsNull());
		}
	}
}
