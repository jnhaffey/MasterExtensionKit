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
			return source > minimumValue;
		}
	}
}