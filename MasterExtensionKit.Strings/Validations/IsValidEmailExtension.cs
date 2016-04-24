using System.Text.RegularExpressions;

namespace MasterExtensionKit.Strings.Validations
{
	public static class IsValidEmailExtension { 

		/// <summary>
		///     Checks if string is a valid Email Address
		/// </summary>
		/// <param name="value"></param>
		/// <param name="format"></param>
		/// <returns></returns>
		public static bool IsValidEmail(this string value, string format = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
		{
			var regex = new Regex(format, RegexOptions.IgnoreCase);
			return regex.IsMatch(value);
		}
	}
}