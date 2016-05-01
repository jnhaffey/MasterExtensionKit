using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Numbers.Validations
{
	public static class IsGreaterThanExtensions
	{
		/// <summary>
		///     Checks if given number is greater than provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="minimumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsGreaterThan(this int source, int minimumValue)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source > minimumValue;
		}

		/// <summary>
		///     Checks if given number is greater than provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="minimumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsGreaterThan(this decimal source, decimal minimumValue)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source > minimumValue;
		}

		/// <summary>
		///     Checks if given number is greater than provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="minimumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsGreaterThan(this float source, float minimumValue)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source > minimumValue;
		}
	}
}