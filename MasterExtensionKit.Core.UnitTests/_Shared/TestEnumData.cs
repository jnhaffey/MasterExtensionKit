using MasterExtensionKit.Core.Attributes;

namespace MasterExtensionKit.Core.UnitTests._Shared
{
	public static class TestEnumData
	{
		public enum DescriptiveEnum
		{
			NoDescription = 0,

			[EnumDescription("")] EmptyDescription = 1,

			[EnumDescription("This is a description")] HasDescription = 2
		}

		public enum GuidEnum
		{
			NoGuid = 0,

			[EnumGuid("")] EmptyGuid = 1,

			[EnumGuid("9EF4F4BE-69E2-4C43-98DD-9531CC721621")] HasGuid = 2
		}

		public enum UserType
		{
			None = 0,
			Administrator = 1,
			Manager = 2,
			Consultant = 3
		}
	}
}