using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Functions
{
	[TestClass]
	public class RepeatExtensionUnitTests
	{
		[TestMethod]
		public void String_Function_Repeat_Twice_Valid()
		{
			var expectedResults = TestStringData.RANDOM_ALPHANUMERIC_STIRNG + TestStringData.RANDOM_ALPHANUMERIC_STIRNG;
			var actualResults = TestStringData.RANDOM_ALPHANUMERIC_STIRNG.Repeat(TestNumberData.INTEGER_POSITIVE_TWO);
			Assert.AreEqual(expectedResults, actualResults);
		}

		[TestMethod]
		[ExpectedException(typeof (UnknownOrUnsupportedOptionException), "The 'count' does not support the value: 0")]
		public void String_Function_Repeat_Zero_Valid()
		{
			var actualResults = TestStringData.RANDOM_ALPHANUMERIC_STIRNG.Repeat(TestNumberData.INTEGER_ZERO);
		}

		[TestMethod]
		[ExpectedException(typeof (UnknownOrUnsupportedOptionException), "The 'count' does not support the value: -1")]
		public void String_Function_Repeat_NegitiveOne_Valid()
		{
			var actualResults = TestStringData.RANDOM_ALPHANUMERIC_STIRNG.Repeat(TestNumberData.INTEGER_NEGATIVE_ONE);
		}

		//[TestMethod]
		//[ExpectedException(typeof(UnknownOrUnsupportedOptionException), "The 'count' does not support the value: 0")]
		//public void String_Function_Repeat_NullCount_Exception()
		//{
		//	var actualResults = TestStringData.RANDOM_ALPHANUMERIC_STIRNG.Repeat(TestNumberData.INTEGER_NULL);
		//}

		#region General String Tests

		//[TestMethod]
		//[ExpectedException(typeof (SourceNullException), "The 'count' does not support the value: -1")]
		//public void String_Function_Repeat_Null_Exception()
		//{
		//	TestStringData.NULL_STRING.Repeat(TestNumberData.INTEGER_NULL);
		//}

		[TestMethod]
		[ExpectedException(typeof (SourceNullException), "")]
		public void String_Function_Repeat_Empty_Exception()
		{
			TestStringData.NULL_STRING.Repeat(TestNumberData.INTEGER_NEGATIVE_ONE);
		}

		#endregion
	}
}