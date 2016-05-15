using System;

namespace MasterExtensionKit.Core.Configuration
{
	/// <summary>
	///     Static Error Message Store
	/// </summary>
	internal static class ErrorMessages
	{
		/// <summary>
		///     Used for Generating a Conversion Error Message
		/// </summary>
		/// <param name="fromType">The Type the conversion was from</param>
		/// <param name="toType">The Type the conversion was to</param>
		/// <returns>Error Message</returns>
		internal static string GenerateConversionError(string fromType, string toType)
		{
			return $"Failed to convert {fromType} to {toType}.";
		}

		/// <summary>
		///     Used for Generating an Enum Not Found From Guid Error Message
		/// </summary>
		/// <param name="guidValue">The Guid that was searched for</param>
		/// <returns>Error Message</returns>
		internal static string EnumNotFoundFromGuidError(Guid guidValue)
		{
			return $"No enum value was found with Guid ID: {guidValue}";
		}

		/// <summary>
		///     Used for Generating an Enum Not Found From String Error Message
		/// </summary>
		/// <param name="value">The string that was searched for</param>
		/// <returns>Error Message</returns>
		internal static string EnumNotFoundFromStringError(string value)
		{
			return $"No enum value was found with value: {value}";
		}

		/// <summary>
		///     Used for Generating an Unknown or Unsupported Country Error Message
		/// </summary>
		/// <returns>Error Message</returns>
		internal static string UnknownUnsupportedCountryError()
		{
			return "The country supplied is either unknown or unsupported at this time.";
		}

		/// <summary>
		///     Used for Generating an Unsupported Numeric Value Error Message
		/// </summary>
		/// <param name="parameterName">The name of the parameter for the method</param>
		/// <param name="value">The value supplied to the parameter</param>
		/// <returns>Error Message</returns>
		internal static string UnsupportedNumericValueError(string parameterName, string value)
		{
			return $"The '{parameterName}' does not support the value: {value}";
		}

		/// <summary>
		///     Used for Generating an Outer Limit Double Value Error Message
		/// </summary>
		/// <param name="isMax">Optional: Set if Maximum</param>
		/// <returns>Error Message</returns>
		internal static string OuterLimitDoubleValueError(bool isMax = false)
		{
			var limit = isMax ? "maximum" : "minimum";
			return $"The {limit} limit of a double was supplied and is unable to parse";
		}
	}
}