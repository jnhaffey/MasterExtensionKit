using System;
using MasterExtensionKit.Core.Strings.Functions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Functions
{
	[TestClass]
	public class EncryptDecryptExtensionsTests
	{
		private readonly string _key = "secret";
		private readonly string _unEncryptedData = "This is the test data";

		[TestMethod]
		[ExpectedException(typeof (ArgumentException), "Cannot encrypt using an empty key. Please supply an encryption key.")]
		public void Encrypt_EmptyKey_Exception()
		{
			_unEncryptedData.Encrypt("");
		}

		[TestMethod]
		[ExpectedException(typeof (ArgumentException), "An empty string value cannot be encrypted.")]
		public void Encrypt_EmptyValue_Exception()
		{
			var emptyValue = string.Empty;
			emptyValue.Encrypt(_key);
		}

		[TestMethod]
		public void Encrypt_Decrypt_Successful()
		{
			var encryptedData = _unEncryptedData.Encrypt(_key);
			var decryptedData = encryptedData.Decrypt(_key);
			Assert.AreEqual(_unEncryptedData, decryptedData);
		}

		[TestMethod]
		[ExpectedException(typeof (ArgumentException), "Cannot decrypt using an empty key. Please supply a decryption key.")]
		public void Decrypt_EmptyKey_Exception()
		{
			_unEncryptedData.Decrypt("");
		}

		[TestMethod]
		[ExpectedException(typeof (ArgumentException), "An empty string value cannot be decrypted.")]
		public void Decrypt_EmptyValue_Exception()
		{
			var emptyValue = string.Empty;
			emptyValue.Decrypt(_key);
		}
	}
}