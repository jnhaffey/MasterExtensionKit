namespace MasterExtensionKit.Numerics.Checks
{
	public static class IsCheckExtensions
	{
		#region Integers

		public static bool IsEven(this int value)
		{
			return value%2 == 0;
		}

		public static bool IsOdd(this int value)
		{
			return !value.IsEven();
		}

		public static bool IsGreaterThan(this int value, int minimumValue)
		{
			return value > minimumValue;
		}

		public static bool IsGreaterThanOrEqual(this int value, int minimumValue)
		{
			return value >= minimumValue;
		}

		public static bool IsLessThan(this int value, int maximumValue)
		{
			return value < maximumValue;
		}

		public static bool IsLessThanOrEqual(this int value, int maximumValue)
		{
			return value <= maximumValue;
		}

		#endregion

		#region Decimals

		public static bool IsGreaterThan(this decimal value, decimal minimumValue)
		{
			return value > minimumValue;
		}

		public static bool IsGreaterThanOrEqual(this decimal value, decimal minimumValue)
		{
			return value >= minimumValue;
		}

		public static bool IsLessThan(this decimal value, decimal maximumValue)
		{
			return value < maximumValue;
		}

		public static bool IsLessThanOrEqual(this decimal value, decimal maximumValue)
		{
			return value <= maximumValue;
		}

		#endregion

		#region Floats

		public static bool IsGreaterThan(this float value, float minimumValue)
		{
			return value > minimumValue;
		}

		public static bool IsGreaterThanOrEqual(this float value, float minimumValue)
		{
			return value >= minimumValue;
		}

		public static bool IsLessThan(this float value, float maximumValue)
		{
			return value < maximumValue;
		}

		public static bool IsLessThanOrEqual(this float value, float maximumValue)
		{
			return value <= maximumValue;
		}

		#endregion
	}
}