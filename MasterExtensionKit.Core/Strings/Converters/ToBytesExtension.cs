using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;
using MasterExtensionKit.Core.Strings.Validations;

namespace MasterExtensionKit.Core.Strings.Converters
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class ToBytesExtension
	{
		/// <summary>
		///     Converts the given string to a byte array
		/// </summary>
		/// <param name="source">The string source</param>
		/// <returns>A Byte array</returns>
		public static byte[] ToBytes(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (!source.HasValue())
			{
				throw new SourceEmptyException(nameof(source));
			}

			var bytes = new byte[source.Length*sizeof(char)];
			Buffer.BlockCopy(source.ToCharArray(), 0, bytes, 0, bytes.Length);
			return bytes;
		}
	}
}