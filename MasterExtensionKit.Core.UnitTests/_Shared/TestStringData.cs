using System;
using System.Globalization;

namespace MasterExtensionKit.Core.UnitTests._Shared
{
	public static class TestStringData
	{
		#region IP Address Strings

		public const string IP_ADDRESS_0_0_0_0 = "0.0.0.0";
		public const string IP_ADDRESS_1_1_1_1 = "1.1.1.1";
		public const string IP_ADDRESS_254_254_254_254 = "254.254.254.254";
		public const string IP_ADDRESS_255_255_255_255 = "255.255.255.255";

		#endregion

		#region Format Style Strings

		public const string STRING_PROPER_STYLE = "The quick brown fox jumps over a lazy dog";
		public const string STRING_PASCAL_STYLE = "TheQuickBrownFoxJumpsOverALazyDog";
		public const string STRING_CAMEL_STYLE = "theQuickBrownFoxJumpsOverALazyDog";

		#endregion

		#region General Strings

		public const string NULL_STRING = null;
		public const string EMPTY_STRING = "";
		public const string WHITESPACE_STRING = " ";
		public static readonly string RANDOM_ALPHANUMERIC_STIRNG = Guid.NewGuid().ToString().Replace("-", "");
		public const string ALPHA_ONLY_STRING = "AbCdEfGhIjKlMnOpQrStUvWxYz";
		public static readonly string ALPHA_ONLY_UPPER_STRING = ALPHA_ONLY_STRING.ToUpper();
		public static readonly string ALPHA_ONLY_LOWER_STRING = ALPHA_ONLY_STRING.ToLower();
		//NOTE: Base64 of MasterExtensionKit.Core.UnitTests._Shared.TestStringData.STRING_PROPER_STYLE
		public const string BASE64_STRING = "VGhlIHF1aWNrIGJyb3duIGZveCBqdW1wcyBvdmVyIGEgbGF6eSBkb2c=";

		#endregion

		#region Postal Code Strings

		public const string UNITED_STATES_FIVE_CHAR_FORMAT_VALID = "12345";
		public const string UNITED_STATES_FIVE_CHAR_FORMAT_INVALID = "1234A";
		public const string UNITED_STATES_TEN_CHAR_FORMAT_STYLE_ONE_VALID = "12345 1234";
		public const string UNITED_STATES_TEN_CHAR_FORMAT_STYLE_TWO_VALID = "12345-1234";
		public const string UNITED_STATES_TEN_CHAR_FORMAT_STYLE_INVALID_ONE = "123451234";
		public const string UNITED_STATES_TEN_CHAR_FORMAT_SYTLE_INVALID_TWO = "12345  1234";
		public const string UNITED_STATES_TEN_CHAR_FORMAT_STYLE_INVALID_THREE = "12345_1234";
		public const string UNITED_KINGDOM_FORMAT_ONE_VALID = "SW1A 2JY";
		public const string UNITED_KINGDOM_FORMAT_TWO_VALID = "SW1A2JY";

		#endregion

		#region Email Address Strings

		public const string EMAIL_CUSTOM_FORMATTER = @"^[\w-\._]+@([\w-]+\.)+[\w-]{2,4}$";
		public const string EMAIL_ADDRESS_STANDARD_VALID = "johndoe@example.com";
		public const string EMAIL_ADDRESS_CUSTOM_VALID = "john_doe@example.com";
		public const string EMAIL_ADDRESS_INVALID = "john*doe@example.com";

		#endregion

		#region String Longs

		public static readonly string LONG_MIN_VALUE = long.MinValue.ToString();
		public static readonly string LONG_ZERO_VALUE = ((long) 0).ToString();
		public static readonly string LONG_MAX_VALUE = long.MaxValue.ToString();

		#endregion

		#region String Integers

		public static readonly string INTEGER_MIN_VALUE = int.MinValue.ToString();
		public static readonly string INTEGER_ZERO_VALUE = 0.ToString();
		public static readonly string INTEGER_MAX_VALUE = int.MaxValue.ToString();

		#endregion

		#region String Shorts

		public static readonly string SHORT_MIN_VALUE = short.MinValue.ToString();
		public static readonly string SHORT_ZERO_VALUE = ((short) 0).ToString();
		public static readonly string SHORT_MAX_VALUE = short.MaxValue.ToString();

		#endregion

		#region String Doubles

		public static readonly string DOUBLE_MIN_VALUE = double.MaxValue.ToString(CultureInfo.InvariantCulture);
		public static readonly string DOUBLE_ZERO_VALUE = ((double) 0).ToString(CultureInfo.InvariantCulture);
		public static readonly string DOUBLE_MAX_VALUE = double.MinValue.ToString(CultureInfo.InvariantCulture);

		#endregion

		#region String Decimals

		public static readonly string DECIMAL_MIN_VALUE = decimal.MinValue.ToString(CultureInfo.InvariantCulture);
		public static readonly string DECIMAL_ZERO_VALUE = ((decimal) 0).ToString(CultureInfo.InvariantCulture);
		public static readonly string DECIMAL_MAX_VALUE = decimal.MaxValue.ToString(CultureInfo.InvariantCulture);

		#endregion

		#region String Floats

		public static readonly string FLOAT_MIN_VALUE = float.MinValue.ToString(CultureInfo.InvariantCulture);
		public static readonly string FLOAT_ZERO_VALUE = ((float) 0).ToString(CultureInfo.InvariantCulture);
		public static readonly string FLOAT_MAX_VALUE = float.MaxValue.ToString(CultureInfo.InvariantCulture);

		#endregion

		#region String GUIDS

		public const string GUID_N_FORMAT = "b04219cbf24b4f318a4963362b4e8d4b";
		public const string GUID_D_FORMAT = "b04219cb-f24b-4f31-8a49-63362b4e8d4b";
		public const string GUID_B_FORMAT = "{b04219cb-f24b-4f31-8a49-63362b4e8d4b}";
		public const string GUID_P_FORMAT = "(b04219cb-f24b-4f31-8a49-63362b4e8d4b)";
		public const string GUID_X_FORMAT = "{0xb04219cb,0xf24b,0x4f31,{0x8a,0x49,0x63,0x36,0x2b,0x4e,0x8d,0x4b}}";

		#endregion
	}
}