namespace MasterExtensionKit.Core.Configuration
{
	/// <summary>
	///     Static Encoding Bytes Store
	/// </summary>
	internal static class EncodingBytes
	{
		/// <summary>
		///     Byte Array for ASCII
		/// </summary>
		internal static readonly int[] AsciiBytes = {0x54, 0x68, 0x65, 0x20};

		/// <summary>
		///     Byte Array for UTF7
		/// </summary>
		internal static readonly int[] Utf7Bytes = {0x54, 0x68, 0x65, 0x20};

		/// <summary>
		///     Byte Array for UTF8
		/// </summary>
		internal static readonly int[] Utf8Bytes = {0xef, 0xbb, 0xbf, 0x54};

		/// <summary>
		///     Byte Array for UTF32
		/// </summary>
		internal static readonly int[] Utf32Bytes = {0xff, 0xfe, 0x0, 0x0};

		/// <summary>
		///     Byte Array for Unicode
		/// </summary>
		internal static readonly int[] UnicodeBytes = {0xff, 0xfe, 0x54, 0x0};

		/// <summary>
		///     Byte Array for BigEndianUnicode
		/// </summary>
		internal static readonly int[] BigEndianUnicodeBytes = {0xfe, 0xff, 0x0, 0x54};
	}
}