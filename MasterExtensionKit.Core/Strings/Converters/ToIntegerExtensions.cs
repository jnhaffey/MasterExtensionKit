using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Converters
{
	public static class ToIntegerExtensions
	{
		/// <summary>
		///     Convert a string to an integer
		/// </summary>
		/// <param name="source"></param>
		/// <param name="ignoreError">Will ignore exceptions - Default: true</param>
		/// <returns></returns>
		public static int? ToInteger(this string source, bool ignoreError = true)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
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
				throw new ConversionFailureException(ErrorMessages.GenerateConversionError("string","integer"), ex);
			}
			return valueToReturn;
		}
	}
}