using System;

namespace MasterExtensionKit.Core.Attributes
{
	[AttributeUsage(AttributeTargets.Field)]
	public class EnumGuidAttribute : Attribute
	{
		/// <summary>
		///     Constructor used to initiate a Guid Attribute
		/// </summary>
		/// <param name="guid">String value converted to Guid and held</param>
		public EnumGuidAttribute(string guid)
		{
			EnumGuid = string.IsNullOrWhiteSpace(guid) ? Guid.Empty : Guid.Parse(guid);
		}

		/// <summary>
		///     Constructor used to initiate a Guid Attribute
		/// </summary>
		/// <param name="guid">Guild to be held</param>
		public EnumGuidAttribute(Guid guid)
		{
			EnumGuid = guid;
		}

		/// <summary>
		///     Holds the Guid Value for the Enum
		/// </summary>
		public Guid EnumGuid { get; private set; }
	}
}