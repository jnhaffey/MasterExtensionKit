using System;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Converters
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class ToEnumExtension
	{
		/// <summary>
		///     Converts a string to an enum
		/// </summary>
		/// <typeparam name="T">The enum to convert to</typeparam>
		/// <param name="source">The string source</param>
		/// <param name="ignoreError">Optional: If errors should be ignored</param>
		/// <returns>The enum value for the given string</returns>
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
				return (T)Enum.Parse(typeof(T), source, true);
			}
			catch (Exception ex)
			{
				throw new EnumNotFoundFromStringException(ErrorMessages.EnumNotFoundFromStringError(source), ex);
			}
		}
	}
}