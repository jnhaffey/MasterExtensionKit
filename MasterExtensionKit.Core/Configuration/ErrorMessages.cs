using System;

namespace MasterExtensionKit.Core.Configuration
{
	internal static class ErrorMessages
	{
		internal static string GenerateConversionError(string fromType, string toType)
		{
			return $"Failed to convert {fromType} to {toType}.";
		}

		internal static string EnumNotFoundFromGuidError(Guid guidValue)
		{
			return $"No enum value was found with Guid ID: {guidValue}";
		}

		internal static string EnumNotFoundFromStringError(string value)
		{
			return $"No enum value was found with value: {value}";
		}

		internal static string UnknownUnsupportedCountryError()
		{
			return "The country supplied is either unknown or unsupported at this time.";
		}

		internal static string UnsupportedNumericValueError(string parameterName, string value)
		{
			return $"The '{parameterName}' does not support the value: {value}";
		}

		internal static string OutterLimitDoubleValueError(bool isMax = false)
		{
			var limit = isMax ? "maximum" : "minimum";
			return $"The {limit} limit of a double was supplied and is unable to parse";
		}
	}
}