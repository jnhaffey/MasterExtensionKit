namespace MasterExtensionKit.Core.Numbers.Validations
{
	public static class IsLessThanExtensions
	{
		/// <summary>
		///     Checks if given number is less than provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThan(this int source, int maximumValue)
		{
			return source < maximumValue;
		}

		/// <summary>
		///     Checks if given number is less than provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThan(this decimal source, decimal maximumValue)
		{
			return source < maximumValue;
		}

		/// <summary>
		///     Checks if given number is less than provided number
		/// </summary>
		/// <param name="source"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThan(this float source, float maximumValue)
		{
			return source < maximumValue;
		}
	}
}