using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Enumerations;
using MasterExtensionKit.Core.Exceptions;

namespace MasterExtensionKit.Core.Strings.Validations
{
	public static class IsValidPostalZipCode
	{
		/// <summary>
		///     Checks the given string to validate as a postal code for the provided country
		/// </summary>
		/// <param name="source"></param>
		/// <param name="countryToValidate">Country Enumeration</param>
		/// <returns>Boolean</returns>
		public static bool IsValidPostalCode(this string source, Country countryToValidate)
		{
			switch (countryToValidate)
			{
				case Country.UnitedStates:
					return ValidateCode(source, RegExpressions.UNITED_STATES);
				case Country.UnitedKingdom:
					return ValidateCode(source, RegExpressions.UNITED_KINGDOM);
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