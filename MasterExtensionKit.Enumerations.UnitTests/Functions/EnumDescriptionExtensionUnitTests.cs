using System;
using MasterExtensionKit.Enumerations.Attributes;
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
			Assert.AreEqual(null, TestEnum.NoDescription.GetDescription());
		}

		[TestMethod]
		public void EmptyEnumDescription_True()
		{
			Assert.AreEqual(String.Empty, TestEnum.EmptyDescription.GetDescription());
		}

		[TestMethod]
		public void HasEnumDescription_True()
		{
			Assert.AreEqual("This is a description", TestEnum.HasDescription.GetDescription());
		}
	}

	public enum TestEnum
	{
		NoDescription = 0,
		[EnumDescription("")]
		EmptyDescription = 1,
		[EnumDescription("This is a description")]
		HasDescription = 2
	}
}
