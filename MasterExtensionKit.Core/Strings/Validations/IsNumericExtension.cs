using System.Globalization;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;
using MasterExtensionKit.Core.Strings.Functions;

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
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (source.EqualsCultureInveriant(StaticDataStore.MIN_DOUBLE_VALUE))
			{
				throw new MininumDoubleLimitException(ErrorMessages.OutterLimitDoubleValueError());
			}

			if (source.EqualsCultureInveriant(StaticDataStore.MAX_DOUBLE_VALUE))
			{
				throw new MaximunDoubleLimitException(ErrorMessages.OutterLimitDoubleValueError(true));
			}

			float floatValue;
			double doubleValue;
			decimal decimalValue;
			if (float.TryParse(source, NumberStyles.Float, NumberFormatInfo.InvariantInfo, out floatValue) ||
			    double.TryParse(source, NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out doubleValue) ||
			    decimal.TryParse(source, NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out decimalValue))
			{
				return true;
			}


			long longValue;
			if (long.TryParse(source, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out longValue))
			{
				return true;
			}

			return false;
		}
	}
}