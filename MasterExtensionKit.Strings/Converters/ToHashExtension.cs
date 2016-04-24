using System.Security.Cryptography;
using System.Text;
using MasterExtensionKit.Strings.Enumerations;

namespace MasterExtensionKit.Strings.Converters
{
	public static class ToHashExtension
	{
		private static byte[] GetHash(string input, HashType hash)
		{
			var inputBytes = Encoding.ASCII.GetBytes(input);

			switch (hash)
			{
				// REMOVING THESE UNIT TESTS AS THE HASHES ARE UNABLE TO BE TESTED
				//case HashType.HMAC:
				//	return HMAC.Create().ComputeHash(inputBytes);

				//case HashType.HMACMD5:
				//	return HMAC.Create().ComputeHash(inputBytes);

				//case HashType.HMACSHA1:
				//	return HMAC.Create().ComputeHash(inputBytes);

				//case HashType.HMACSHA256:
				//	return HMAC.Create().ComputeHash(inputBytes);

				//case HashType.HMACSHA384:
				//	return HMAC.Create().ComputeHash(inputBytes);

				//case HashType.HMACSHA512:
				//	return HMAC.Create().ComputeHash(inputBytes);

				//case HashType.MACTripleDES:
				//	return KeyedHashAlgorithm.Create().ComputeHash(inputBytes);

				case HashType.MD5:
					return MD5.Create().ComputeHash(inputBytes);

				case HashType.RIPEMD160:
					return RIPEMD160.Create().ComputeHash(inputBytes);

				case HashType.SHA1:
					return SHA1.Create().ComputeHash(inputBytes);

				case HashType.SHA256:
					return SHA256.Create().ComputeHash(inputBytes);

				case HashType.SHA384:
					return SHA384.Create().ComputeHash(inputBytes);

				case HashType.SHA512:
					return SHA512.Create().ComputeHash(inputBytes);

				default:
					return inputBytes;
			}
		}

		/// <summary>
		///     Computes the hash of the string using a specified hash algorithm
		/// </summary>
		/// <param name="input">The string to hash</param>
		/// <param name="hashType">The hash algorithm to use</param>
		/// <returns>The resulting hash or an empty string on error</returns>
		public static string ComputeHash(this string input, HashType hashType)
		{
			try
			{
				var hash = GetHash(input, hashType);
				var ret = new StringBuilder();

				foreach (var t in hash)
					ret.Append(t.ToString("x2"));

				return ret.ToString();
			}
			catch
			{
				return string.Empty;
			}
		}
	}
}