using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Numbers.Validations
{
	/// <summary>
	///     Number Extension Method
	/// </summary>
	public static class IsGreaterThanOrEqualExtensions
	{
		/// <summary>
		///     Evaluates if given number is greater than or equal to provided number
		/// </summary>
		/// <param name="source">The source number</param>
		/// <param name="minimumValue">The number to evaluate against</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool IsGreaterThanOrEqual(this int source, int minimumValue)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source >= minimumValue;
		}

		/// <summary>
		///     Evaluates if given number is greater than or equal to provided number
		/// </summary>
		/// <param name="source">The source number</param>
		/// <param name="minimumValue">The number to evaluate against</param>
		/// <returns>Boolean indicating if it passes or not</returns>
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
		///     Evaluates if given number is greater than or equal to provided number
		/// </summary>
		/// <param name="source">The source number</param>
		/// <param name="minimumValue">The number to evaluate against</param>
		/// <returns>Boolean indicating if it passes or not</returns>
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