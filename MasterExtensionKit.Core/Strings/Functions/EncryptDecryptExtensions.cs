using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using MasterExtensionKit.Core.Strings.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class EncryptDecryptExtensions
	{
		/// <summary>
		///     Encrypts the given string using the provided key
		/// </summary>
		/// <param name="source">The string source</param>
		/// <param name="key">The key to use to encrypt</param>
		/// <returns>The encrypted string</returns>
		public static string Encrypt(this string source, string key)
		{
			if (!source.HasValue())
			{
				throw new ArgumentException("An empty string value cannot be encrypted.");
			}

			if (!key.HasValue())
			{
				throw new ArgumentException("Cannot encrypt using an empty key. Please supply an encryption key.");
			}

			var cspp = new CspParameters {KeyContainerName = key};

			var rsa = new RSACryptoServiceProvider(cspp) {PersistKeyInCsp = true};

			var bytes = rsa.Encrypt(Encoding.UTF8.GetBytes(source), true);

			return BitConverter.ToString(bytes);
		}

		/// <summary>
		///     Decrypts the given string using the provided key
		/// </summary>
		/// <param name="source">The string source</param>
		/// <param name="key">The key to use to decrypt</param>
		/// <returns>The decrypted string</returns>
		public static string Decrypt(this string source, string key)
		{
			string result = null;

			if (!source.HasValue())
			{
				throw new ArgumentException("An empty string value cannot be decrypted.");
			}

			if (!key.HasValue())
			{
				throw new ArgumentException("Cannot decrypt using an empty key. Please supply a decryption key.");
			}

			try
			{
				var cspp = new CspParameters {KeyContainerName = key};

				var rsa = new RSACryptoServiceProvider(cspp) {PersistKeyInCsp = true};

				var decryptArray = source.Split(new[] {"-"}, StringSplitOptions.None);

				var decryptByteArray = Array.ConvertAll(decryptArray, s => Convert.ToByte(byte.Parse(s, NumberStyles.HexNumber)));

				var bytes = rsa.Decrypt(decryptByteArray, true);

				result = Encoding.UTF8.GetString(bytes);
			}
			catch
			{
				// TODO: Make better Exception Handling
				throw;
			}

			return result;
		}
	}
}