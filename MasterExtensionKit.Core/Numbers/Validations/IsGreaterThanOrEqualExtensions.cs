using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Numbers.Validations
{
	public static class IsGreaterThanOrEqualExtensions
	{
		/// <summary>
		///     Checks if given number is greater than or equal to provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="minimumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsGreaterThanOrEqual(this int source, int minimumValue)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source >= minimumValue;
		}

		/// <summary>
		///     Checks if given number is greater than or equal to provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="minimumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsGreaterThanOrEqual(this decimal source, decimal minimumValue)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source >= minimumValue;
		}

		/// ///
		/// <summary>
		///     Checks if given number is greater than or equal to provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="minimumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsGreaterThanOrEqual(this float source, float minimumValue)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source >= minimumValue;
		}
	}
}