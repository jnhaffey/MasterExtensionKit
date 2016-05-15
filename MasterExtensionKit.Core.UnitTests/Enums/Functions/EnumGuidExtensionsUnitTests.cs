using MasterExtensionKit.Core.Enums.Functions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Enums.Functions
{
	[TestClass]
	public class EnumGuidExtensionsUnitTests
	{
		[TestMethod]
		public void Enum_Function_EnumGuid_GetGuid_Matches()
		{
			Assert.AreEqual(TestGuidData.GUID_D_FORMAT, TestEnumData.GuidEnum.HAS_GUID.GetGuid());
		}

		[TestMethod]
		public void Enum_Function_EnumGuid_GetEnum_Matches()
		{
			var myEnum = TestEnumData.GuidEnum.EMPTY_GUID;
			var actualResult = myEnum.GetEnumValue(TestGuidData.GUID_D_FORMAT);
			Assert.AreEqual(TestEnumData.GuidEnum.HAS_GUID, actualResult);
		}
	}
}