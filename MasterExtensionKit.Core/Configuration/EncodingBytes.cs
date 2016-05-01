namespace MasterExtensionKit.Core.Configuration
{
	internal static class EncodingBytes
	{
		internal static readonly int[] AsciiBytes = {0x54, 0x68, 0x65, 0x20};
		internal static readonly int[] Utf7Bytes = {0x54, 0x68, 0x65, 0x20};
		internal static readonly int[] Utf8Bytes = {0xef, 0xbb, 0xbf, 0x54};
		internal static readonly int[] Utf32Bytes = {0xff, 0xfe, 0x0, 0x0};
		internal static readonly int[] UnicodeBytes = {0xff, 0xfe, 0x54, 0x0};
		internal static readonly int[] BigEndianUnicodeBytes = {0xfe, 0xff, 0x0, 0x54};
	}
}