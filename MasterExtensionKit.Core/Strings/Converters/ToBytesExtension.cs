using System;

namespace MasterExtensionKit.Core.Strings.Converters
{
	public static class ToBytesExtension
	{
		public static byte[] ToBytes(this string source)
		{
			var bytes = new byte[source.Length*sizeof (char)];
			Buffer.BlockCopy(source.ToCharArray(), 0, bytes, 0, bytes.Length);
			return bytes;
		}
	}
}