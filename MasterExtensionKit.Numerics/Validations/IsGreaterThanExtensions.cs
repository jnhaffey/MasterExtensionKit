namespace MasterExtensionKit.Numerics.Validations
{
	public static class IsGreaterThanExtensions
	{
		/// <summary>
		///     Checks if given number is greater than provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="minimumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsGreaterThan(this int value, int minimumValue)
		{
			return value > minimumValue;
		}

		/// <summary>
		///     Checks if given number is greater than provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="minimumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsGreaterThan(this decimal value, decimal minimumValue)
		{
			return value > minimumValue;
		}

		/// <summary>
		///     Checks if given number is greater than provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="minimumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsGreaterThan(this float value, float minimumValue)
		{
			return value > minimumValue;
		}
	}
}