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

		internal static string UnknownUnsupportedCountryError()
		{
			return "The country supplied is either unknown or unsupported at this time.";
		}
	}
}