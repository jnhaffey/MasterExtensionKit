using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Validations
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class IsValidIpAddressExtension
	{
		/// <summary>
		///     Evaluates if the given string is a valid IP Address
		/// </summary>
		/// <param name="source">The string source</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool IsValidIpAddress(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return Regex.IsMatch(source, RegExpressions.IP_ADDRESS);
		}
	}
}