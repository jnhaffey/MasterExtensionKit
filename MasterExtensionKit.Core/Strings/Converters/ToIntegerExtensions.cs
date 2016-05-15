using System;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;
using MasterExtensionKit.Core.Strings.Validations;

namespace MasterExtensionKit.Core.Strings.Converters
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class ToIntegerExtensions
	{
		/// <summary>
		///     Convert a string to an integer
		/// </summary>
		/// <param name="source">The source string</param>
		/// <param name="ignoreError">Optional: Will ignore exceptions</param>
		/// <returns>Returns the integer of the string value</returns>
		public static int? ToInteger(this string source, bool ignoreError = true)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (!source.HasValue())
			{
				throw new SourceEmptyException(nameof(source));
			}

			int? valueToReturn = null;
			try
			{
				valueToReturn = int.Parse(source);
			}
			catch (Exception ex)
			{
				if (ignoreError)
				{
					return null;
				}

				throw new ConversionFailureException(ErrorMessages.GenerateConversionError("string", "integer"), ex);
			}

			return valueToReturn;
		}
	}
}