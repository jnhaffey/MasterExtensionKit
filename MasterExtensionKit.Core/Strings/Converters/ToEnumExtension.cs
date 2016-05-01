using System;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Converters
{
	public static class ToEnumExtension
	{
		/// <summary>
		///     Converts a string to an enum
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <param name="ignoreError"></param>
		/// <returns></returns>
		public static T ToEnum<T>(this string source, bool ignoreError = true) where T : struct
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (ignoreError)
			{
				T returnValue;
				return Enum.TryParse(source, true, out returnValue) ? returnValue : default(T);
			}
			try
			{
				return (T) Enum.Parse(typeof (T), source, true);
			}
			catch (Exception ex)
			{
				throw new EnumNotFoundFromStringException(ErrorMessages.EnumNotFoundFromStringError(source), ex);
			}
		}
	}
}