using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Numbers.Validations
{
	/// <summary>
	///     Number Extension Method
	/// </summary>
	public static class IsLessThanOrEqualExtensions
	{
		/// <summary>
		///     Evaluates if given number is less than or equal to provided number
		/// </summary>
		/// <param name="source">The source number</param>
		/// <param name="maximumValue">The number to evaluate against</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool IsLessThanOrEqual(this int source, int maximumValue)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source <= maximumValue;
		}

		/// <summary>
		///     Evaluates if given number is less than or equal to provided number
		/// </summary>
		/// <param name="source">The source number</param>
		/// <param name="maximumValue">The number to evaluate against</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool IsLessThanOrEqual(this decimal source, decimal maximumValue)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source <= maximumValue;
		}

		/// <summary>
		///     Evaluates if given number is less than or equal to provided number
		/// </summary>
		/// <param name="source">The source number</param>
		/// <param name="maximumValue">The number to evaluate against</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool IsLessThanOrEqual(this float source, float maximumValue)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source <= maximumValue;
		}
	}
}