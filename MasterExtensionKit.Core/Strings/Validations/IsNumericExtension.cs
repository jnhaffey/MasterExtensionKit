using System.Globalization;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;
using MasterExtensionKit.Core.Strings.Functions;

namespace MasterExtensionKit.Core.Strings.Validations
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class IsNumericExtension
	{
		/// <summary>
		///     Will validate if a string is a number
		/// </summary>
		/// <param name="source">The string source</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool IsNumeric(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (source.EqualsCultureInveriant(StaticDataStore.MinDoubleValue))
			{
				throw new MinimumDoubleLimitException(ErrorMessages.OuterLimitDoubleValueError());
			}

			if (source.EqualsCultureInveriant(StaticDataStore.MaxDoubleValue))
			{
				throw new MaximumDoubleLimitException(ErrorMessages.OuterLimitDoubleValueError(true));
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