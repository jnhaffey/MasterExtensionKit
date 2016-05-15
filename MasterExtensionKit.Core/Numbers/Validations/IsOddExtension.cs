using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Numbers.Validations
{
	/// <summary>
	///     Number Extension Method
	/// </summary>
	public static class IsOddExtension
	{
		/// <summary>
		///     Evaluate if number is Odd
		/// </summary>
		/// <param name="source">The source number</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool IsOdd(this int source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return !source.IsEven();
		}
	}
}