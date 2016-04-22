using System.Globalization;
using System.Text.RegularExpressions;

namespace MasterExtensionKit.Strings.Checks
{
	public static class IsCheckExtensions
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool IsNumeric(this string value)
		{
			long retNum;
			return long.TryParse(value, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out retNum);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		/// <param name="format"></param>
		/// <returns></returns>
		public static bool IsValidEmail(this string value, string format = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
		{
			var regex = new Regex(format);
			return regex.IsMatch(value);
		}
	}
}