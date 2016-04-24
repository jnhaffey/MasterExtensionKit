namespace MasterExtensionKit.Numerics.Validations
{
	public static class IsLessThanExtensions
	{
		/// <summary>
		///     Checks if given number is less than provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThan(this int value, int maximumValue)
		{
			return value < maximumValue;
		}

		/// <summary>
		///     Checks if given number is less than provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThan(this decimal value, decimal maximumValue)
		{
			return value < maximumValue;
		}

		/// <summary>
		///     Checks if given number is less than provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThan(this float value, float maximumValue)
		{
			return value < maximumValue;
		}
	}
}