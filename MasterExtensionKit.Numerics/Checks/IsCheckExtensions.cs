namespace MasterExtensionKit.Numerics.Checks
{
	public static class IsCheckExtensions
	{
		#region Integers

		/// <summary>
		///     Checks if number is Even
		/// </summary>
		/// <param name="value"></param>
		/// <returns>Boolean</returns>
		public static bool IsEven(this int value)
		{
			return value%2 == 0;
		}

		/// <summary>
		///     Checks if number is Odd
		/// </summary>
		/// <param name="value"></param>
		/// <returns>Boolean</returns>
		public static bool IsOdd(this int value)
		{
			return !value.IsEven();
		}

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
		///     Checks if given number is less than or equal to provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThanOrEqual(this int value, int maximumValue)
		{
			return value <= maximumValue;
		}

		#endregion

		#region Decimals

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
		///     Checks if given number is greater than or equal to provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="minimumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsGreaterThanOrEqual(this decimal value, decimal minimumValue)
		{
			return value >= minimumValue;
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
		///     Checks if given number is less than or equal to provided number
		/// </summary>
		/// <param name="value"></param>
		/// <param name="maximumValue"></param>
		/// <returns>Boolean</returns>
		public static bool IsLessThanOrEqual(this decimal value, decimal maximumValue)
		{
			return value <= maximumValue;
		}

		#endregion

		#region Floats

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

		#endregion
	}
}