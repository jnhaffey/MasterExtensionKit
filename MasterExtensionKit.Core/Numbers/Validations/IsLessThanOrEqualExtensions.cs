namespace MasterExtensionKit.Core.Numbers.Validations
{
	public static class IsLessThanOrEqualExtensions
	{
		/// <summary>
		///     Checks if given number is less than or equal to provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThanOrEqual(this int source, int maximumValue)
		{
			return source <= maximumValue;
		}

		/// <summary>
		///     Checks if given number is less than or equal to provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThanOrEqual(this decimal source, decimal maximumValue)
		{
			return source <= maximumValue;
		}

		/// <summary>
		///     Checks if given number is less than or equal to provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThanOrEqual(this float source, float maximumValue)
		{
			return source <= maximumValue;
		}
	}
}