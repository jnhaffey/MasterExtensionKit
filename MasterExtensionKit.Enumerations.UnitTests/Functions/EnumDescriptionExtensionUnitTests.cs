using MasterExtensionKit.Enumerations.Functions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Enumerations.UnitTests.Functions
{
	[TestClass]
	public class EnumDescriptionExtensionUnitTests
	{
		[TestMethod]
		public void NoEnumDescription_True()
		{
			Assert.AreEqual(null, TestData.DescriptiveEnum.NoDescription.GetDescription());
		}

		[TestMethod]
		public void EmptyEnumDescription_True()
		{
			Assert.AreEqual(string.Empty, TestData.DescriptiveEnum.EmptyDescription.GetDescription());
		}

		[TestMethod]
		public void HasEnumDescription_True()
		{
			Assert.AreEqual("This is a description", TestData.DescriptiveEnum.HasDescription.GetDescription());
		}
	}
}