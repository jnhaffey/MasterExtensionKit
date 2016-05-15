using System;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Converters
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class ToDecimalExtension
	{
		/// <summary>
		///     Convert a string to an decimal
		/// </summary>
		/// <param name="source">The source string</param>
		/// <param name="ignoreError">Optional: Will ignore exceptions</param>
		/// <returns>Returns the decimal of the string value</returns>
		public static decimal? ToDecimal(this string source, bool ignoreError = true)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			decimal? valueToReturn = null;

			try
			{
				valueToReturn = decimal.Parse(source);
			}
			catch (Exception ex)
			{
				if (ignoreError)
				{
					return null;
				}

				throw new ConversionFailureException(ErrorMessages.GenerateConversionError("string", "decimal"), ex);
			}

			return valueToReturn;
		}
	}
}