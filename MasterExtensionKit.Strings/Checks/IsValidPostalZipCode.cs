using System;
using System.Text.RegularExpressions;

namespace MasterExtensionKit.Strings.Checks
{
	public static class IsValidPostalZipCode
	{
		private const string UNITED_STATES = @"^\d{5}(?:[-\s]\d{4})?$";

		private const string UNITED_KINGDOM =
			@"^(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|(([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|(([A-Z-[QVX]][0-9][A-HJKPSTUW])|([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY])))) [0-9][A-Z-[CIKMOV]]{2})$";

		/// <summary>
		///     Checks the given string to validate as a postal code for the provided country
		/// </summary>
		/// <param name="value"></param>
		/// <param name="countryToValidate">Country Enumeration</param>
		/// <returns>Boolean</returns>
		public static bool IsValidPostalCode(this string value, Country countryToValidate)
		{
			switch (countryToValidate)
			{
				case Country.UnitedStates:
					return ValidateCode(value, UNITED_STATES);
				case Country.UnitedKingdom:
					return ValidateCode(value, UNITED_KINGDOM);
				default:
					throw new Exception();
			}
		}

		private static bool ValidateCode(string value, string format)
		{
			var regex = new Regex(format, RegexOptions.IgnoreCase);
			return regex.IsMatch(value);
		}
	}

	public enum Country
	{
		UnitedStates = 0,
		UnitedKingdom = 1
	}
}