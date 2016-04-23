using System;
using MasterExtensionKit.Strings.Functions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Strings.UnitTests.Functions
{
	[TestClass]
	public class ToHashExtensionsUnitTest
	{
		const string dataToHash = "I am test data that will be hashed";

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
		public void ComputeHash_MD5()
		{
			var expectedResults = "df1bb7a4f090c13f0d5ae866e9505b86";
			var actualResults = dataToHash.ComputeHash(HashType.MD5);
			Assert.AreEqual(expectedResults, actualResults);
		}

		[TestMethod]
		public void ComputeHash_RIPEMD160()
		{
			var expectedResults = "1d4b03163a73c98ec9ca9e8db54193ac71470f40";
			var actualResults = dataToHash.ComputeHash(HashType.RIPEMD160);
			Assert.AreEqual(expectedResults, actualResults);
		}

		[TestMethod]
		public void ComputeHash_SHA1()
		{
			var expectedResults = "b06fb7cf44efb838b7d6267a7ba2efe738a6da5c";
			var actualResults = dataToHash.ComputeHash(HashType.SHA1);
			Assert.AreEqual(expectedResults, actualResults);
		}

		[TestMethod]
		public void ComputeHash_SHA256()
		{
			var expectedResults = "53a78ea2b4c7b0b16349b9127becb6935ebed1a4929e65400d2116e1d506b2c4";
			var actualResults = dataToHash.ComputeHash(HashType.SHA256);
			Assert.AreEqual(expectedResults, actualResults);
		}

		[TestMethod]
		public void ComputeHash_SHA384()
		{
			var expectedResults = "5264817ef76c9b52c12873096f09a66142642b3283b71ed026a3c2f2905d5b11dd071e2d1753f137ae029626b5f07cd3";
			var actualResults = dataToHash.ComputeHash(HashType.SHA384);
			Assert.AreEqual(expectedResults, actualResults);
		}

		[TestMethod]
		public void ComputeHash_SHA512()
		{
			var expectedResults = "2bc4aac7da3e1f8682a074d96e7da5de912c1e9419e77f60e0fa12eed373331462d82e4bb10aed8996694373b969ed520c5050b843aafdf710dab0923b1f60e5";
			var actualResults = dataToHash.ComputeHash(HashType.SHA512);
			Assert.AreEqual(expectedResults, actualResults);
		}
	}
}
