using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Configuration;

namespace MasterExtensionKit.Core.Strings.Validations
{
	public static class IsValidIpAddressExtension
	{
		/// <summary>
		///     Checks if the given string is a valid IP Address
		/// </summary>
		/// <param name="source"></param>
		/// <returns>Boolean</returns>
		public static bool IsValidIPAddress(this string source)
		{
			return Regex.IsMatch(source, RegExpressions.IP_ADDRESS_REG_EXPRESSION);
		}
	}
}