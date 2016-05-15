using System.Collections;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Converters;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Converters
{
	[TestClass]
	public class ToBytesExtensionUnitTests
	{
		[TestMethod]
		public void String_Converter_ToBytes_Matching_Length()
		{
			var expectedResults = TestByteData.DataToSaveBytes;
			var actualResults = TestStringData.STRING_PROPER_STYLE.ToBytes();
			Assert.AreEqual(expectedResults.Length, actualResults.Length);
		}

		[TestMethod]
		public void String_Converter_ToBytes_Matching_Value()
		{
			var expectedResults = TestByteData.DataToSaveBytes;
			var actualResults = TestStringData.STRING_PROPER_STYLE.ToBytes();
			Assert.IsTrue(StructuralComparisons.StructuralEqualityComparer.Equals(expectedResults, actualResults));
		}

		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void String_Converter_ToBytes_Null_Exception()
		{
			TestStringData.NULL_STRING.ToBytes();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceEmptyException), "")]
		public void String_Converter_ToBytes_Empty_Invalid()
		{
			TestStringData.EMPTY_STRING.ToBytes();
		}

		#endregion
	}
}