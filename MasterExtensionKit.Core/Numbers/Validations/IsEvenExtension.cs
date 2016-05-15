using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Numbers.Validations
{
	/// <summary>
	///     Number Extension Method
	/// </summary>
	public static class IsEvenExtension
	{
		/// <summary>
		///     Evaluates if number is Even
		/// </summary>
		/// <param name="source">The source number</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool IsEven(this int source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source%2 == 0;
		}
	}
}