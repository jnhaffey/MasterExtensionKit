using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Numbers.Validations
{
	public static class IsLessThanExtensions
	{
		/// <summary>
		///     Checks if given number is less than provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThan(this int source, int maximumValue)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source < maximumValue;
		}

		/// <summary>
		///     Checks if given number is less than provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThan(this decimal source, decimal maximumValue)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source < maximumValue;
		}

		/// <summary>
		///     Checks if given number is less than provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThan(this float source, float maximumValue)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source < maximumValue;
		}
	}
}