using System.Globalization;

namespace MasterExtensionKit.Core.Strings.Validations
{
	public static class IsNumericExtension
	{
		/// <summary>
		///     Checks if string is numeric
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		public static bool IsNumeric(this string source)
		{
			float floatValue;
			if (float.TryParse(source, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out floatValue))
			{
				return true;
			}

			double doubleValue;
			if (double.TryParse(source, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out doubleValue))
			{
				return true;
			}

			decimal decimalValue;
			if (decimal.TryParse(source, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out decimalValue))
			{
				return true;
			}

			long longValue;
			if (long.TryParse(source, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out longValue))
			{
				return true;
			}

			int intValue;
			if (int.TryParse(source, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out intValue))
			{
				return true;
			}
			return false;
		}
	}
}