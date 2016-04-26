using System.Text.RegularExpressions;

namespace MasterExtensionKit.Core.Strings.Validations
{
	public static class IsValidIpAddressExtension
	{
		private const string IP_ADDRESS_REG_EXPRESSION =
			@"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";

		/// <summary>
		///     Checks if the given string is a valid IP Address
		/// </summary>
		/// <param name="source"></param>
		/// <returns>Boolean</returns>
		public static bool IsValidIPAddress(this string source)
		{
			return Regex.IsMatch(source, IP_ADDRESS_REG_EXPRESSION);
		}
	}
}