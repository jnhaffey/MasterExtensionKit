using System;
using MasterExtensionKit.Core.Exceptions;

namespace MasterExtensionKit.Strings.Converters
{
	public static class ToIntegerExtensions
	{
		/// <summary>
		///     Convert a string to an integer
		/// </summary>
		/// <param name="value"></param>
		/// <param name="ignoreError">Will ignore exceptions - Default: true</param>
		/// <returns></returns>
		public static int? ToInteger(this string value, bool ignoreError = true)
		{
			int? valueToReturn = null;
			try
			{
				valueToReturn = int.Parse(value);
			}
			catch (Exception ex)
			{
				if (ignoreError)
				{
					return null;
				}
				throw new ConversionFailureException("Failed to convert string to interger.", ex);
			}
			return valueToReturn;
		}
	}
}