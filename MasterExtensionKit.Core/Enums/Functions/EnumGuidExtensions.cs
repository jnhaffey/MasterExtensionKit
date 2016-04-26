using System;
using System.Linq;
using MasterExtensionKit.Core.Attributes;

namespace MasterExtensionKit.Core.Enums.Functions
{
	public static class EnumGuidExtensions
	{
		/// <summary>
		///     Will return the Guid associated to the Enum Value
		/// </summary>
		/// <param name="source"></param>
		/// <returns>Guid</returns>
		public static Guid GetGuid(this Enum source)
		{
			var type = source.GetType();
			var fieldInfo = type.GetField(source.ToString());
			var attributes = fieldInfo.GetCustomAttributes(typeof (EnumGuidAttribute), false) as EnumGuidAttribute[];
			return attributes != null && attributes.Length > 0 ? attributes[0].EnumGuid : Guid.Empty;
		}

		/// <summary>
		///     Will return the Enum Value associated to the Guid
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <param name="guid"></param>
		/// <returns>Enum Value</returns>
		public static T GetEnumValue<T>(this T source, Guid guid) where T : struct
		{
			var type = typeof (T);
			var fieldInfo = type.GetFields();
			var fields = from field in fieldInfo
				let attributes = field.GetCustomAttributes(typeof (EnumGuidAttribute), false) as EnumGuidAttribute[]
				where attributes == null || attributes.Any()
				let value = attributes[0].EnumGuid
				where value == guid
				select field;

			foreach (var field in fields)
			{
				T myEnum;
				Enum.TryParse(field.Name, out myEnum);
				return myEnum;
			}
			throw new Exception();
		}
	}
}