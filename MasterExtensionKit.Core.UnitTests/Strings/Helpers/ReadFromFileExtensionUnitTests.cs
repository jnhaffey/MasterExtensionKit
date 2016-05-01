using System.IO;
using System.Text;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Functions;
using MasterExtensionKit.Core.Strings.Helpers;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Helpers
{
	[TestClass]
	public class ReadFromFileExtensionUnitTests
	{
		private string _actualResults;

		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(FileNotFoundException), "")]
		public void String_Function_ReadFromFile_NoFile_Exception()
		{
			_actualResults = TestStringData.NULL_STRING;
			StringHelpers.ReadFromFile(out _actualResults, TestSharedData.TEST_FILE_LOCATION_FILE_NAME);
		}

		[TestMethod]
		public void String_Function_ReadFromFile_Null_Exception()
		{
			CreateFile(null);
			_actualResults = TestStringData.NULL_STRING;
			StringHelpers.ReadFromFile(out _actualResults, TestSharedData.TEST_FILE_LOCATION_FILE_NAME);
			Assert.AreEqual(TestStringData.STRING_PROPER_STYLE, _actualResults);
		}

		[TestMethod]
		public void String_Function_ReadFromFile_Empty_Default_Valid()
		{
			CreateFile(null);
			StringHelpers.ReadFromFile(out _actualResults, TestSharedData.TEST_FILE_LOCATION_FILE_NAME);
			Assert.AreEqual(TestStringData.STRING_PROPER_STYLE, _actualResults);
		}

		[TestMethod]
		public void String_Function_ReadFromFile_Not_Empty_Default_Valid()
		{
			CreateFile(null);
			_actualResults = TestStringData.RANDOM_ALPHANUMERIC_STIRNG;
			StringHelpers.ReadFromFile(out _actualResults, TestSharedData.TEST_FILE_LOCATION_FILE_NAME);
			Assert.AreEqual(TestStringData.STRING_PROPER_STYLE, _actualResults);
		}

		#endregion

		#region Encoding Tests

		[TestMethod]
		public void String_Function_ReadFromFile_Empty_ASCII_Valid()
		{
			CreateFile(Encoding.ASCII);
			StringHelpers.ReadFromFile(out _actualResults, TestSharedData.TEST_FILE_LOCATION_FILE_NAME, Encoding.ASCII);
			Assert.AreEqual(TestStringData.STRING_PROPER_STYLE, _actualResults);
		}

		[TestMethod]
		public void String_Function_ReadFromFile_Empty_UTF7_Valid()
		{
			CreateFile(Encoding.UTF7);
			StringHelpers.ReadFromFile(out _actualResults, TestSharedData.TEST_FILE_LOCATION_FILE_NAME, Encoding.UTF7);
			Assert.AreEqual(TestStringData.STRING_PROPER_STYLE, _actualResults);
		}

		[TestMethod]
		public void String_Function_ReadFromFile_Empty_UTF8_Valid()
		{
			CreateFile(Encoding.UTF8);
			StringHelpers.ReadFromFile(out _actualResults, TestSharedData.TEST_FILE_LOCATION_FILE_NAME, Encoding.UTF8);
			Assert.AreEqual(TestStringData.STRING_PROPER_STYLE, _actualResults);
		}

		[TestMethod]
		public void String_Function_ReadFromFile_Empty_UTF32_Valid()
		{
			CreateFile(Encoding.UTF32);
			StringHelpers.ReadFromFile(out _actualResults, TestSharedData.TEST_FILE_LOCATION_FILE_NAME, Encoding.UTF32);
			Assert.AreEqual(TestStringData.STRING_PROPER_STYLE, _actualResults);
		}

		[TestMethod]
		public void String_Function_ReadFromFile_Empty_Unicode_Valid()
		{
			CreateFile(Encoding.Unicode);
			StringHelpers.ReadFromFile(out _actualResults, TestSharedData.TEST_FILE_LOCATION_FILE_NAME, Encoding.Unicode);
			Assert.AreEqual(TestStringData.STRING_PROPER_STYLE, _actualResults);
		}

		[TestMethod]
		public void String_Function_ReadFromFile_Empty_BigEndianUnicode_Valid()
		{
			CreateFile(Encoding.BigEndianUnicode);
			StringHelpers.ReadFromFile(out _actualResults, TestSharedData.TEST_FILE_LOCATION_FILE_NAME, Encoding.BigEndianUnicode);
			Assert.AreEqual(TestStringData.STRING_PROPER_STYLE, _actualResults);
		}

		#endregion

		#region Pre-Post Test

		[TestInitialize]
		public void PreTestInitialization()
		{
			if (File.Exists(TestSharedData.TEST_FILE_LOCATION_FILE_NAME))
			{
				File.Delete(TestSharedData.TEST_FILE_LOCATION_FILE_NAME);
			}
		}

		[TestCleanup]
		public void PostTestCleanup()
		{
			if (File.Exists(TestSharedData.TEST_FILE_LOCATION_FILE_NAME))
			{
				File.Delete(TestSharedData.TEST_FILE_LOCATION_FILE_NAME);
			}
		}

		private void CreateFile(Encoding encodingToUse)
		{
			TestStringData.STRING_PROPER_STYLE.SaveToFile(TestSharedData.TEST_FILE_LOCATION_FILE_NAME, false, encodingToUse);
		}

		#endregion
	}
}