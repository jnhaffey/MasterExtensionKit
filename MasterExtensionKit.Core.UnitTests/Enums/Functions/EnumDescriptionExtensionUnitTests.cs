﻿using MasterExtensionKit.Core.Enums.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Enums.Functions
{
	[TestClass]
	public class EnumDescriptionExtensionUnitTests
	{
		[TestMethod]
		public void NoEnumDescription_True()
		{
			Assert.AreEqual(null, TestEnumData.DescriptiveEnum.NO_DESCRIPTION.GetDescription());
		}

		[TestMethod]
		public void EmptyEnumDescription_True()
		{
			Assert.AreEqual(string.Empty, TestEnumData.DescriptiveEnum.EMPTY_DESCRIPTION.GetDescription());
		}

		[TestMethod]
		public void HasEnumDescription_True()
		{
			Assert.AreEqual("This is a description", TestEnumData.DescriptiveEnum.HAS_DESCRIPTION.GetDescription());
		}
	}
}