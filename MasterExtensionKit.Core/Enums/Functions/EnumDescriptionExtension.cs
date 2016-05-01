using System;
using MasterExtensionKit.Core.Attributes;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Enums.Functions
{
	public static class EnumDescriptionExtension
	{
		/// <summary>
		///     Will return the String Value for a given enumeration, if one exists.
		/// </summary>
		/// <returns type="String">String Value</returns>
		public static string GetDescription(this Enum source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var type = source.GetType();
			var fieldInfo = type.GetField(source.ToString());
			var attributes =
				fieldInfo.GetCustomAttributes(typeof (EnumDescriptionAttribute), false) as EnumDescriptionAttribute[];
			return attributes != null && attributes.Length > 0 ? attributes[0].EnumDescription : null;
		}
	}
}