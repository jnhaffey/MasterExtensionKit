using MasterExtensionKit.Core.Enums.Functions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Enums.Functions
{
	[TestClass]
	public class EnumDescriptionExtensionUnitTests
	{
		[TestMethod]
		public void Enum_Function_NoEnumDescription_True()
		{
			Assert.AreEqual(null, TestEnumData.DescriptiveEnum.NO_DESCRIPTION.GetDescription());
		}

		[TestMethod]
		public void Enum_Function_EmptyEnumDescription_True()
		{
			Assert.AreEqual(string.Empty, TestEnumData.DescriptiveEnum.EMPTY_DESCRIPTION.GetDescription());
		}

		[TestMethod]
		public void Enum_Function_HasEnumDescription_True()
		{
			Assert.AreEqual("This is a description", TestEnumData.DescriptiveEnum.HAS_DESCRIPTION.GetDescription());
		}
	}
}