using System;
using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Enumerations;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Validations
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class IsValidPostalZipCode
	{
		/// <summary>
		///     Evaluates the given string to validate as a postal code for the provided country
		/// </summary>
		/// <param name="source">The string source</param>
		/// <param name="countryToValidate" type="Country">Country Enumeration</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool IsValidPostalCode(this string source, Country countryToValidate)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (countryToValidate.IsNull())
			{
				throw new ArgumentNullException(nameof(countryToValidate));
			}

			switch (countryToValidate)
			{
				case Country.UNITED_STATES:
					return ValidateCode(source, RegExpressions.POSTAL_CODE_UNITED_STATES);
				case Country.UNITED_KINGDOM:
					return ValidateCode(source, RegExpressions.POSTAL_CODE_UNITED_KINGDOM);
				default:
					throw new UnknownOrUnsupportedOptionException(ErrorMessages.UnknownUnsupportedCountryError());
			}
		}

		private static bool ValidateCode(string value, string format)
		{
			var regex = new Regex(format, RegexOptions.IgnoreCase);
			return regex.IsMatch(value);
		}
	}
}