using System;

namespace MasterExtensionKit.Core.UnitTests._Shared
{
	public static class TestNumberData
	{
		#region Encryption Related

		public const int ENCRYPTED_DATA_LENGHT = 383;

		#endregion

		#region SHORT VALUES

		public static short? SHORT_NULL;
		public static short SHORT_DEFAULT = default(short);
		public static short SHORT_MIN_VALUE = Int16.MinValue;
		public const short SHORT_NEGATIVE_TWO = -2;
		public const short SHORT_NEGATIVE_ONE = -1;
		public const short SHORT_ZERO = 0;
		public const short SHORT_POSITIVE_ONE = 1;
		public const short SHORT_POSITIVE_TWO = 2;
		public static short SHORT_MAX_VALUE = Int16.MaxValue;

		#endregion

		#region INTEGER VALUES

		public static int? INTEGER_NULL;
		public static int INTEGER_DEFAULT = default(int);
		public static int INTEGER_MIN_VALUE = Int32.MinValue;
		public const int INTEGER_NEGATIVE_TWO = -2;
		public const int INTEGER_NEGATIVE_ONE = -1;
		public const int INTEGER_ZERO = 0;
		public const int INTEGER_POSITIVE_ONE = 1;
		public const int INTEGER_POSITIVE_TWO = 2;
		public static int INTEGER_MAX_VALUE = Int32.MaxValue;

		#endregion

		#region LONG VALUES

		public static long? LONG_NULL;
		public static long LONG_DEFAULT = default(long);
		public static long LONG_MIN_VALUE = Int64.MinValue;
		public const long LONG_NEGATIVE_TWO = -2;
		public const long LONG_NEGATIVE_ONE = -1;
		public const long LONG_ZERO = 0;
		public const long LONG_POSITIVE_ONE = 1;
		public const long LONG_POSITIVE_TWO = 2;
		public static long LONG_MAX_VALUE = Int64.MaxValue;

		#endregion

		#region DOUBLE VALUES

		public static double? DOUBLE_NULL;
		public static double DOUBLE_DEFAULT = default(double);
		public static double DOUBLE_MIN_VALUE = Double.MinValue;
		public const double DOUBLE_NEGATIVE_TWO = -2.0D;
		public const double DOUBLE_NEGATIVE_ONE = -1.0D;
		public const double DOUBLE_ZERO = 0.0D;
		public const double DOUBLE_POSITIVE_ONE = 1.0D;
		public const double DOUBLE_POSITIVE_TWO = 2.0D;
		public static double DOUBLE_MAX_VALUE = Double.MaxValue;

		#endregion

		#region DECIMALS VALUES

		public static decimal? DECIMAL_NULL;
		public static decimal DECIMAL_DEFAULT = default(decimal);
		public static decimal DECIMAL_MIN_VALUE = Decimal.MinValue;
		public const decimal DECIMAL_NEGATIVE_TWO = -2.0M;
		public const decimal DECIMAL_NEGATIVE_ONE = -1.0M;
		public const decimal DECIMAL_ZERO = 0.0M;
		public const decimal DECIMAL_POSITIVE_ONE = 1.0M;
		public const decimal DECIMAL_POSITIVE_TWO = 2.0M;
		public static decimal DECIMAL_MAX_VALUE = Decimal.MaxValue;

		#endregion

		#region FLOATS VALUES

		public static float? FLOAT_NULL;
		public static float FLOAT_DEFAULT = default(float);
		public static float FLOAT_MIN_VALUE = Single.MinValue;
		public const float FLOAT_NEGATIVE_TWO = -2.0F;
		public const float FLOAT_NEGATIVE_ONE = -1.0F;
		public const float FLOAT_ZERO = 0.0F;
		public const float FLOAT_POSITIVE_ONE = 1.0F;
		public const float FLOAT_POSITIVE_TWO = 2.0F;
		public static float FLOAT_MAX_VALUE = Single.MaxValue;

		#endregion
	}
}