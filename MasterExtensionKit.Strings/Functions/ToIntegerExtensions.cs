using System;
using MasterExtensionKit.Core.Exceptions;

namespace MasterExtensionKit.Strings.Functions
{
	public static class ToIntegerExtensions
	{
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
				else
				{
					throw new ConversionFailureException("Failed to convert string to interger", ex);
				}
			}
			return valueToReturn;
		}
	}
}
