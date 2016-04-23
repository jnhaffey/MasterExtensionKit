using System.Globalization;
using System.Text.RegularExpressions;

namespace MasterExtensionKit.Strings.Checks
{
	public static class IsCheckExtensions
	{
		/// <summary>
		///     Checks if string is numeric
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool IsNumeric(this string value)
		{
			float floatValue;
			if (float.TryParse(value, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out floatValue))
			{
				return true;
			}

			double doubleValue;
			if (double.TryParse(value, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out doubleValue))
			{
				return true;
			}

			decimal decimalValue;
			if (decimal.TryParse(value, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out decimalValue))
			{
				return true;
			}

			long longValue;
			if (long.TryParse(value, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out longValue))
			{
				return true;
			}

			int intValue;
			if (int.TryParse(value, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out intValue))
			{
				return true;
			}
			return false;
		}

		/// <summary>
		///     Checks if string is a valid Email Address
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