namespace MasterExtensionKit.Core.Numbers.Validations
{
	public static class IsGreaterThanOrEqualExtensions
	{
		/// <summary>
		///     Checks if given number is greater than or equal to provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="minimumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsGreaterThanOrEqual(this int value, int minimumValue)
		{
			return value >= minimumValue;
		}

		/// <summary>
		///     Checks if given number is greater than or equal to provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="minimumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsGreaterThanOrEqual(this decimal value, decimal minimumValue)
		{
			return value >= minimumValue;
		}

		/// ///
		/// <summary>
		///     Checks if given number is greater than or equal to provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="minimumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsGreaterThanOrEqual(this float value, float minimumValue)
		{
			return value >= minimumValue;
		}
	}
}