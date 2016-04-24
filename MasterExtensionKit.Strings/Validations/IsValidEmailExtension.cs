using System.Text.RegularExpressions;

namespace MasterExtensionKit.Strings.Validations
{
	public static class IsValidEmailExtension
	{
		private const string EMAIL_REG_EXPRESSION = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

		/// <summary>
		///     Checks if string is a valid Email Address
		/// </summary>
		/// <param name="value"></param>
		/// <param name="format"></param>
		/// <returns></returns>
		public static bool IsValidEmail(this string value, string format = EMAIL_REG_EXPRESSION)
		{
			var regex = new Regex(format, RegexOptions.IgnoreCase);
			return regex.IsMatch(value);
		}
	}
}