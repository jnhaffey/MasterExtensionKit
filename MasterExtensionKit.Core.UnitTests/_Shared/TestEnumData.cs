using MasterExtensionKit.Core.Attributes;

namespace MasterExtensionKit.Core.UnitTests._Shared
{
	public static class TestEnumData
	{
		public enum DescriptiveEnum
		{
			NO_DESCRIPTION = 0,

			[EnumDescription("")]
			EMPTY_DESCRIPTION = 1,

			[EnumDescription("This is a description")]
			HAS_DESCRIPTION = 2
		}

		public enum GuidEnum
		{
			NO_GUID = 0,

			[EnumGuid("")]
			EMPTY_GUID = 1,

			[EnumGuid(TestStringData.GUID_D_FORMAT)]
			HAS_GUID = 2
		}

		public enum UserType
		{
			NONE = 0,
			ADMINISTRATOR = 1,
			MANAGER = 2,
			CONSULTANT = 3
		}
	}
}