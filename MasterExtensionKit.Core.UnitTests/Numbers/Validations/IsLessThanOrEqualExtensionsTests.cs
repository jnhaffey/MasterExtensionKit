using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Numbers.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Numbers.Validations
{
	[TestClass]
	public class IsLessThanOrEqualExtensionsTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Number_Validation_IsLessThanOrEqual_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Number_Validation_IsLessThanOrEqual_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion

		[TestMethod]
		public void Number_Validation_Integer_NegativeTwo_IsLessThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.INTEGER_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Integer_NegativeTwo_IsLessThanOrEqual_NegativeOne_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.INTEGER_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Number_Validation_Integer_NegativeTwo_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.INTEGER_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Integer_NegativeTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.INTEGER_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Integer_Zero_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_ZERO.IsLessThanOrEqual(TestNumberData.INTEGER_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Integer_Zero_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_ZERO.IsLessThanOrEqual(TestNumberData.INTEGER_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Integer_Zero_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_ZERO.IsLessThanOrEqual(TestNumberData.INTEGER_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Integer_PositiveTwo_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.INTEGER_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Integer_PositiveTwo_IsLessThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.INTEGER_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Integer_PositiveTwo_IsLessThanOrEqual_PositiveOne_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.INTEGER_POSITIVE_ONE));
		}

		[TestMethod]
		public void Number_Validation_Integer_PositiveTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.INTEGER_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_NegativeTwo_IsLessThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_NegativeTwo_IsLessThanOrEqual_NegativeOne_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Number_Validation_Decimal_NegativeTwo_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_NegativeTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_Zero_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_ZERO.IsLessThanOrEqual(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_Zero_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_ZERO.IsLessThanOrEqual(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_Zero_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_ZERO.IsLessThanOrEqual(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_PositiveTwo_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_PositiveTwo_IsLessThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_PositiveTwo_IsLessThanOrEqual_PositiveOne_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_POSITIVE_ONE));
		}

		[TestMethod]
		public void Number_Validation_Decimal_PositiveTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Float_NegativeTwo_IsLessThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Float_NegativeTwo_IsLessThanOrEqual_NegativeOne_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Number_Validation_Float_NegativeTwo_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Float_NegativeTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Float_Zero_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_ZERO.IsLessThanOrEqual(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Float_Zero_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_ZERO.IsLessThanOrEqual(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Float_Zero_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_ZERO.IsLessThanOrEqual(TestNumberData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Float_PositiveTwo_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Float_PositiveTwo_IsLessThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Float_PositiveTwo_IsLessThanOrEqual_PositiveOne_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_POSITIVE_ONE));
		}

		[TestMethod]
		public void Number_Validation_Float_PositiveTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_POSITIVE_TWO.IsLessThanOrEqual(TestNumberData.FLOAT_POSITIVE_TWO));
		}
	}
}