using System;

namespace MasterExtensionKit.Core.Attributes
{
	/// <summary>
	///     Holds a Guid Value for a given Enumeration Value
	/// </summary>
	[AttributeUsage(AttributeTargets.Field)]
	public class EnumGuidAttribute : Attribute
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="EnumGuidAttribute" /> class
		/// </summary>
		/// <param name="guid">This is the guid that will be stored</param>
		public EnumGuidAttribute(string guid)
		{
			this.EnumGuid = string.IsNullOrWhiteSpace(guid) ? Guid.Empty : Guid.Parse(guid);
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="EnumGuidAttribute" /> class
		/// </summary>
		/// <param name="guid">This is the guid that will be stored</param>
		public EnumGuidAttribute(Guid guid)
		{
			this.EnumGuid = guid;
		}

		/// <summary>
		///     Gets and Holds the Guid Value for the Enum
		/// </summary>
		public Guid EnumGuid { get; private set; }
	}
}