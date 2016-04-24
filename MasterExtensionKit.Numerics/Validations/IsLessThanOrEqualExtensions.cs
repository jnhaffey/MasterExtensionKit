namespace MasterExtensionKit.Numerics.Validations
{
	public static class IsLessThanOrEqualExtensions
	{
		/// <summary>
		///     Checks if given number is less than or equal to provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThanOrEqual(this int value, int maximumValue)
		{
			return value <= maximumValue;
		}

		/// <summary>
		///     Checks if given number is less than or equal to provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThanOrEqual(this decimal value, decimal maximumValue)
		{
			return value <= maximumValue;
		}

		/// <summary>
		///     Checks if given number is less than or equal to provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThanOrEqual(this float value, float maximumValue)
		{
			return value <= maximumValue;
		}
	}
}