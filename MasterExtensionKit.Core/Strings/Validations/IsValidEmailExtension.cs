using System;
using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Validations
{
	public static class IsValidEmailExtension
	{
		/// <summary>
		///     Checks if string is a valid Email Address
		/// </summary>
		/// <param name="source"></param>
		/// <param name="format"></param>
		/// <returns></returns>
		public static bool IsValidEmail(this string source, string format = RegExpressions.EMAIL_REG_EXPRESSION)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var regex = new Regex(format, RegexOptions.IgnoreCase);
			return regex.IsMatch(source);
		}
	}
}