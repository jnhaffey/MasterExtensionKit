using System.Globalization;

namespace MasterExtensionKit.Strings.Validations
{
	public static class IsNumericExtension
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
	}
}