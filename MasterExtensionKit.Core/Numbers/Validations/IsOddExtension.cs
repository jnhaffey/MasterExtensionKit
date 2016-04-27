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
			return !source.IsEven();
		}
	}
}