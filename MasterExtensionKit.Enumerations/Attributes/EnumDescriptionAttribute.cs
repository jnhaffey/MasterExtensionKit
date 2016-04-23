using System;

namespace MasterExtensionKit.Enumerations.Attributes
{
	/// <summary>
	///     This attribute is used to represent a string value for a value in an enumeration
	/// </summary>
	[AttributeUsage(AttributeTargets.Field)]
	public class EnumDescriptionAttribute : Attribute
	{
		/// <summary>
		///     Constructor used to initiate a Description Attribute
		/// </summary>
		/// <param name="value">String to hold</param>
		public EnumDescriptionAttribute(string value)
		{
			EnumDescription = value;
		}

		/// <summary>
		///     Holds a string value for an enumeration value
		/// </summary>
		public string EnumDescription { get; private set; }
	}
}