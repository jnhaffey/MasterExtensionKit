using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Converters
{
	public static class ToBytesExtension
	{
		public static byte[] ToBytes(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var bytes = new byte[source.Length*sizeof (char)];
			Buffer.BlockCopy(source.ToCharArray(), 0, bytes, 0, bytes.Length);
			return bytes;
		}
	}
}