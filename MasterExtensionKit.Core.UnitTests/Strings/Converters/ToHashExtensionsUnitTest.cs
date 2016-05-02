using MasterExtensionKit.Core.Enumerations;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Converters;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Converters
{
	[TestClass]
	public class ToHashExtensionsUnitTest
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void String_Converter_ToHash_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void String_Converter_ToHash_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion

		// REMOVING THESE UNIT TESTS AS THE HASHES ARE UNABLE TO BE TESTED

		//[TestMethod]
		//public void ComputeHash_HMAC()
		//{
		//	var expectedResults = "5b12c738d4a582fc8244060580e60b644c1f822a";
		//	var actualResults = dataToHash.ComputeHash(HashType.HMAC);
		//	Assert.AreEqual(expectedResults, actualResults);
		//}

		//[TestMethod]
		//public void ComputeHash_HMACMD5()
		//{
		//	var expectedResults = "aa4b3d9d2ddfc038128df95d1abad5e4dd41a0a9";
		//	var actualResults = dataToHash.ComputeHash(HashType.HMACMD5);
		//	Assert.AreEqual(expectedResults, actualResults);
		//}

		//[TestMethod]
		//public void ComputeHash_HMACSHA1()
		//{
		//	var expectedResults = "540d909128eb5e4b65536a780d0e303e6715d42d";
		//	var actualResults = dataToHash.ComputeHash(HashType.HMACSHA1);
		//	Assert.AreEqual(expectedResults, actualResults);
		//}

		//[TestMethod]
		//public void ComputeHash_HMACSHA256()
		//{
		//	var expectedResults = "720cafc6ec29095ad51173801188be9fd88da615";
		//	var actualResults = dataToHash.ComputeHash(HashType.HMACSHA256);
		//	Assert.AreEqual(expectedResults, actualResults);
		//}

		//[TestMethod]
		//public void ComputeHash_HMACSHA384()
		//{
		//	var expectedResults = "e6c25fa63d78452209ae17a399d7cd247dd866cc";
		//	var actualResults = dataToHash.ComputeHash(HashType.HMACSHA384);
		//	Assert.AreEqual(expectedResults, actualResults);
		//}

		//[TestMethod]
		//public void ComputeHash_HMACSHA512()
		//{
		//	var expectedResults = "284ce079808c7e31c2c7142f3f55d1f71d5e0c0f";
		//	var actualResults = dataToHash.ComputeHash(HashType.HMACSHA512);
		//	Assert.AreEqual(expectedResults, actualResults);
		//}

		//[TestMethod]
		//public void ComputeHash_MACTripleDES()
		//{
		//	var expectedResults = "b8e52f38c0791fccd9f854422e67b1988cd758e2";
		//	var actualResults = dataToHash.ComputeHash(HashType.MACTripleDES);
		//	Assert.AreEqual(expectedResults, actualResults);
		//}

		[TestMethod]
		public void Strings_Converters_ComputeHash_MD5_Valid()
		{
			Assert.AreEqual(TestStringData.HASH_DATA_MD5, TestStringData.DATA_TO_HASH.ComputeHash(HashType.MD5));
		}

		[TestMethod]
		public void Strings_Converters_ComputeHash_RIPEMD160_Valid()
		{
			Assert.AreEqual(TestStringData.HASH_DATA_RIPEMD160, TestStringData.DATA_TO_HASH.ComputeHash(HashType.RIPEMD160));
		}

		[TestMethod]
		public void Strings_Converters_ComputeHash_SHA1_Valid()
		{
			Assert.AreEqual(TestStringData.HASH_DATA_SHA1, TestStringData.DATA_TO_HASH.ComputeHash(HashType.SHA1));
		}

		[TestMethod]
		public void Strings_Converters_ComputeHash_SHA256_Valid()
		{
			Assert.AreEqual(TestStringData.HASH_DATA_SHA256, TestStringData.DATA_TO_HASH.ComputeHash(HashType.SHA256));
		}

		[TestMethod]
		public void Strings_Converters_ComputeHash_SHA384_Valid()
		{
			Assert.AreEqual(TestStringData.HASH_DATA_SHA384, TestStringData.DATA_TO_HASH.ComputeHash(HashType.SHA384));
		}

		[TestMethod]
		public void Strings_Converters_ComputeHash_SHA512_Valid()
		{
			Assert.AreEqual(TestStringData.HASH_DATA_SHA512, TestStringData.DATA_TO_HASH.ComputeHash(HashType.SHA512));
		}
	}
}