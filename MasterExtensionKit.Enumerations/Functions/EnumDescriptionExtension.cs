using System;
using MasterExtensionKit.Enumerations.Attributes;

namespace MasterExtensionKit.Enumerations.Functions
{
	public static class EnumDescriptionExtension
	{
		/// <summary>
		///     Will return the String Value for a given enumeration, if one exists.
		/// </summary>
		/// <returns type="String">String Value</returns>
		public static string GetDescription(this Enum enumToUse)
		{
			var type = enumToUse.GetType();
			var fieldInfo = type.GetField(enumToUse.ToString());
			var attributes = fieldInfo.GetCustomAttributes(typeof(EnumDescriptionAttribute), false) as EnumDescriptionAttribute[];
			return attributes != null && attributes.Length > 0 ? attributes[0].EnumDescription : null;
		}
	}
}
