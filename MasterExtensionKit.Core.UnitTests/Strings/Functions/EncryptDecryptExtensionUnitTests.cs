using System;
using System.Security.Cryptography;
using MasterExtensionKit.Core.Strings.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Functions
{
	[TestClass]
	public class EncryptDecryptExtensionUnitTests
	{
		private string _encryptedData;

		[TestMethod]
		public void String_Function_Encrypt_Valid()
		{
			EncryptTestData();
			Assert.AreEqual(TestNumberData.ENCRYPTED_DATA_LENGHT, _encryptedData.Length);
		}

		[TestMethod]
		public void String_Function_Decrypt_Valid()
		{
			EncryptTestData();
			Assert.AreEqual(TestStringData.DATA_TO_ENCRYPT, _encryptedData.Decrypt(TestStringData.ENCRYPTION_KEY));
		}

		[TestMethod]
		[ExpectedException(typeof(CryptographicException))]
		public void String_Function_Decrypt_WrongKey_Exception()
		{
			EncryptTestData();
			_encryptedData.Decrypt("WRONGKEY");
		}

		#region General Tests

		[TestMethod]
		[ExpectedException(typeof (ArgumentException), "Cannot encrypt using an empty key. Please supply an encryption key.")]
		public void String_Function_Encrypt_EmptyKey_Exception()
		{
			TestStringData.DATA_TO_ENCRYPT.Encrypt("");
		}

		[TestMethod]
		[ExpectedException(typeof (ArgumentException), "An empty string value cannot be encrypted.")]
		public void String_Function_Encrypt_EmptyValue_Exception()
		{
			TestStringData.EMPTY_STRING.Encrypt(TestStringData.ENCRYPTION_KEY);
		}

		#endregion

		private void EncryptTestData()
		{
			_encryptedData = TestStringData.DATA_TO_ENCRYPT.Encrypt(TestStringData.ENCRYPTION_KEY);
		}
	}
}