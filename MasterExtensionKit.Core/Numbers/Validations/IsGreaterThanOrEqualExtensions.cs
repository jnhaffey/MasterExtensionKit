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
			return source >= minimumValue;
		}
	}
}