using System;
using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Validations
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class IsValidEmailExtension
	{
		/// <summary>
		///     Evaluates if string is a valid Email Address
		/// </summary>
		/// <param name="source">The string source</param>
		/// <param name="format">Optional: Regular Express to validate against</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool IsValidEmail(this string source, string format = RegExpressions.EMAIL)
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