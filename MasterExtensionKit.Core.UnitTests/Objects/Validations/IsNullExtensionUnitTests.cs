using MasterExtensionKit.Core.Objects.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Objects.Validations
{
	[TestClass]
	public class IsNullExtensionUnitTests
	{
		[TestMethod]
		public void Object_Validation_IsNull_True()
		{
			Assert.IsTrue(TestObjectData.NULL_OBJECT.IsNull());
		}

		[TestMethod]
		public void Object_Validation_IsNull_False()
		{
			Assert.IsFalse(TestObjectData.EMPTY_OBJECT.IsNull());
		}
	}
}