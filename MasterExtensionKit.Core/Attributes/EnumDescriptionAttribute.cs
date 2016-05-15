using System;

namespace MasterExtensionKit.Core.Attributes
{
	/// <summary>
	///     Holds a Description Value for a given Enumeration Option
	/// </summary>
	[AttributeUsage(AttributeTargets.Field)]
	public class EnumDescriptionAttribute : Attribute
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="EnumDescriptionAttribute" /> class
		/// </summary>
		/// <param name="value">String to hold</param>
		public EnumDescriptionAttribute(string value)
		{
			this.EnumDescription = value;
		}

		/// <summary>
		///     Gets and holds a string value for an enumeration value
		/// </summary>
		public string EnumDescription { get; private set; }
	}
}