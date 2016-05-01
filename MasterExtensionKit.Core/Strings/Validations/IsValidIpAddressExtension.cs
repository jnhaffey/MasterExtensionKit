using System;
using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Validations
{
	public static class IsValidIpAddressExtension
	{
		/// <summary>
		///     Checks if the given string is a valid IP Address
		/// </summary>
		/// <param name="source"></param>
		/// <returns>Boolean</returns>
		public static bool IsValidIpAddress(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return Regex.IsMatch(source, RegExpressions.IP_ADDRESS_REG_EXPRESSION);
		}
	}
}