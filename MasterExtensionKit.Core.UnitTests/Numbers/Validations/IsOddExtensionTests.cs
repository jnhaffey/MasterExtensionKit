using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Numbers.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Numbers.Validations
{
	public class IsOddExtensionTests
	{
		[TestMethod]
		public void Number_Validation_IsOdd_Integer_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_NEGATIVE_TWO.IsOdd());
		}

		[TestMethod]
		public void Number_Validation_IsOdd_Integer_NegativeOne_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_NEGATIVE_ONE.IsOdd());
		}

		[TestMethod]
		public void Number_Validation_IsOdd_Integer_Zero_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_ZERO.IsOdd());
		}

		[TestMethod]
		public void Number_Validation_IsOdd_Integer_PositiveOne_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_POSITIVE_ONE.IsOdd());
		}

		[TestMethod]
		public void Number_Validation_IsOdd_Integer_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_POSITIVE_TWO.IsOdd());
		}

		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof (SourceNullException), "")]
		public void Number_Validation_IsOdd_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof (SourceNullException), "")]
		public void Number_Validation_IsOdd_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion
	}
}