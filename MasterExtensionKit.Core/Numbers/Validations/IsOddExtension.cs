using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Numbers.Validations
{
	public static class IsOddExtension
	{
		/// <summary>
		///     Checks if number is Odd
		/// </summary>
		/// <param name="source"></param>
		/// <returns>Boolean</returns>
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