using System;
using System.Linq;
using MasterExtensionKit.Core.Attributes;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Objects.Validations;

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
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

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
		/// <param name="ignoreError"></param>
		/// <returns>Enum Value</returns>
		public static T GetEnumValue<T>(this T source, Guid guid, bool ignoreError = true) where T : struct
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (guid.IsNull())
			{
				throw new ArgumentNullException(nameof(guid));
			}

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
			if (ignoreError)
			{
				return default(T);
			}
			throw new EnumNotFoundFromGuidException(ErrorMessages.EnumNotFoundFromGuidError(guid));
		}
	}
}