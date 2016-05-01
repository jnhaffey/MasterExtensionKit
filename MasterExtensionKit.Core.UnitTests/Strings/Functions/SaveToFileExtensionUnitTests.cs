using System.IO;
using System.Text;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static MasterExtensionKit.Core.Helpers.Helpers;

namespace MasterExtensionKit.Core.UnitTests.Strings.Functions
{
	[TestClass]
	public class SaveToFileExtensionUnitTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof (SourceNullException), "")]
		public void String_Function_SaveToFile_Null_Exception()
		{
			TestStringData.NULL_STRING.SaveToFile(TestSharedData.TEST_FILE_LOCATION_FILE_NAME);
		}

		[TestMethod]
		public void String_Function_SaveToFile_Empty_Invalid()
		{
			TestStringData.EMPTY_STRING.SaveToFile(TestSharedData.TEST_FILE_LOCATION_FILE_NAME);
			Assert.IsTrue(File.Exists(TestSharedData.TEST_FILE_LOCATION_FILE_NAME));
		}

		#endregion

		#region Creation / Appending File Tests

		[TestMethod]
		public void String_Function_SaveToFile_DefaultsOptions_FileCreation_Valid()
		{
			TestStringData.STRING_PROPER_STYLE.SaveToFile(TestSharedData.TEST_FILE_LOCATION_FILE_NAME);
			Assert.IsTrue(File.Exists(TestSharedData.TEST_FILE_LOCATION_FILE_NAME));
		}

		[TestMethod]
		public void String_Function_SaveToFile_AppendTrue_FileSizeDouble_Valid()
		{
			TestStringData.STRING_PROPER_STYLE.SaveToFile(TestSharedData.TEST_FILE_LOCATION_FILE_NAME, true);

			var firstFileSize = new FileInfo(TestSharedData.TEST_FILE_LOCATION_FILE_NAME).Length;
			Assert.IsTrue(firstFileSize > 0);

			TestStringData.STRING_PROPER_STYLE.SaveToFile(TestSharedData.TEST_FILE_LOCATION_FILE_NAME, true);
			var secondFileSize = new FileInfo(TestSharedData.TEST_FILE_LOCATION_FILE_NAME).Length;
			Assert.IsTrue(secondFileSize > firstFileSize);
		}

		#endregion

		#region Encoding Tests

		[TestMethod]
		public void String_Function_SaveToFile_ASCII_Encoded_Valid()
		{
			TestStringData.STRING_PROPER_STYLE.SaveToFile(TestSharedData.TEST_FILE_LOCATION_FILE_NAME, false, Encoding.ASCII);

			Assert.AreEqual(Encoding.ASCII, GetTextFileEncoding(TestSharedData.TEST_FILE_LOCATION_FILE_NAME));
		}

		[TestMethod]
		public void String_Function_SaveToFile_UTF7_Encoded_Valid()
		{
			TestStringData.STRING_PROPER_STYLE.SaveToFile(TestSharedData.TEST_FILE_LOCATION_FILE_NAME, false, Encoding.UTF7);

			Assert.AreEqual(Encoding.ASCII, GetTextFileEncoding(TestSharedData.TEST_FILE_LOCATION_FILE_NAME));
		}

		[TestMethod]
		public void String_Function_SaveToFile_UTF8_Encoded_Valid()
		{
			TestStringData.STRING_PROPER_STYLE.SaveToFile(TestSharedData.TEST_FILE_LOCATION_FILE_NAME, false, Encoding.UTF8);

			Assert.AreEqual(Encoding.UTF8, GetTextFileEncoding(TestSharedData.TEST_FILE_LOCATION_FILE_NAME));
		}

		[TestMethod]
		public void String_Function_SaveToFile_UTF32_Encoded_Valid()
		{
			TestStringData.STRING_PROPER_STYLE.SaveToFile(TestSharedData.TEST_FILE_LOCATION_FILE_NAME, false, Encoding.UTF32);

			Assert.AreEqual(Encoding.UTF32, GetTextFileEncoding(TestSharedData.TEST_FILE_LOCATION_FILE_NAME));
		}

		[TestMethod]
		public void String_Function_SaveToFile_UNICODE_Encoded_Valid()
		{
			TestStringData.STRING_PROPER_STYLE.SaveToFile(TestSharedData.TEST_FILE_LOCATION_FILE_NAME, false, Encoding.Unicode);

			Assert.AreEqual(Encoding.Unicode, GetTextFileEncoding(TestSharedData.TEST_FILE_LOCATION_FILE_NAME));
		}

		[TestMethod]
		public void String_Function_SaveToFile_BigEndianUnicode_Encoded_Valid()
		{
			TestStringData.STRING_PROPER_STYLE.SaveToFile(TestSharedData.TEST_FILE_LOCATION_FILE_NAME, false,
				Encoding.BigEndianUnicode);

			Assert.AreEqual(Encoding.BigEndianUnicode, GetTextFileEncoding(TestSharedData.TEST_FILE_LOCATION_FILE_NAME));
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

		#endregion
	}
}