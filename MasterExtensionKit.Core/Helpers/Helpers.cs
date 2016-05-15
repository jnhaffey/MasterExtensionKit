using System.IO;
using System.Text;
using MasterExtensionKit.Core.Configuration;

namespace MasterExtensionKit.Core.Helpers
{
	/// <summary>
	///     General Helper Object
	/// </summary>
	public static class Helpers
	{
		/// <summary>
		///     Determines a text file's encoding by analyzing its byte order mark (BOM).
		///     Defaults to ASCII when detection of the text file's endianness fails.
		/// </summary>
		/// <param name="fileName">The text file to analyze.</param>
		/// <returns>The detected encoding.</returns>
		public static Encoding GetTextFileEncoding(string fileName)
		{
			// Read the BOM
			var bom = new byte[4];
			using (var file = new FileStream(fileName, FileMode.Open, FileAccess.Read))
			{
				file.Read(bom, 0, 4);
			}

			// Analyze the BOM
			// UTF7 (NOT BEING USED
			/*
			if (bom[0] == _utf7Bytes[0] && bom[1] == _utf7Bytes[1] && bom[2] == _utf7Bytes[2] && bom[3] == _utf7Bytes[3])
			{
				return Encoding.UTF7;
			}
			*/

			// UTF8
			if (bom[0] == EncodingBytes.Utf8Bytes[0] && bom[1] == EncodingBytes.Utf8Bytes[1] &&
			    bom[2] == EncodingBytes.Utf8Bytes[2] && bom[3] == EncodingBytes.Utf8Bytes[3])
			{
				return Encoding.UTF8;
			}

			// UTF-32 (UTF-16E)
			if (bom[0] == EncodingBytes.Utf32Bytes[0] && bom[1] == EncodingBytes.Utf32Bytes[1] &&
			    bom[2] == EncodingBytes.Utf32Bytes[2] && bom[3] == EncodingBytes.Utf32Bytes[3])
			{
				return Encoding.UTF32;
			}

			// BigEndianUnicode (UTF-16BE)
			if (bom[0] == EncodingBytes.BigEndianUnicodeBytes[0] && bom[1] == EncodingBytes.BigEndianUnicodeBytes[1] &&
			    bom[2] == EncodingBytes.BigEndianUnicodeBytes[2] && bom[3] == EncodingBytes.BigEndianUnicodeBytes[3])
			{
				return Encoding.BigEndianUnicode;
			}

			// Unicode
			if (bom[0] == EncodingBytes.UnicodeBytes[0] && bom[1] == EncodingBytes.UnicodeBytes[1] &&
			    bom[2] == EncodingBytes.UnicodeBytes[2] && bom[3] == EncodingBytes.UnicodeBytes[3])
			{
				return Encoding.Unicode;
			}

			// DEFAULT ASCII
			return Encoding.ASCII;
		}

		/// <summary>
		///     Gets the Encoding of document by peeking at the file
		/// </summary>
		/// <param name="fileName">The location and file to evaluate</param>
		/// <returns type="Encoding">The encoding type</returns>
		public static Encoding GetEncoding(string fileName)
		{
			Encoding encodingToReturn;
			var defaultEncodingIfNoBom = Encoding.ASCII;
			using (var reader = new StreamReader(fileName, defaultEncodingIfNoBom, true))
			{
				reader.Peek();
				encodingToReturn = reader.CurrentEncoding;
			}

			return encodingToReturn;
		}
	}
}