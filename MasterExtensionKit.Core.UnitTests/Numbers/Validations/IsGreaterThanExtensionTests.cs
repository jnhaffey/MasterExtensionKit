using MasterExtensionKit.Core.Numbers.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Numbers.Validations
{
	public class IsGreaterThanExtensionTests
	{
		[TestMethod]
		public void Number_Validation_Integer_NegativeTwo_IsGreaterThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_NEGATIVE_TWO.IsGreaterThan(TestNumberData.INTEGER_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Integer_NegativeTwo_IsGreaterThan_NegativeOne_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_NEGATIVE_TWO.IsGreaterThan(TestNumberData.INTEGER_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Number_Validation_Integer_NegativeTwo_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_NEGATIVE_TWO.IsGreaterThan(TestNumberData.INTEGER_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Integer_NegativeTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_NEGATIVE_TWO.IsGreaterThan(TestNumberData.INTEGER_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Integer_Zero_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_ZERO.IsGreaterThan(TestNumberData.INTEGER_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Integer_Zero_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_ZERO.IsGreaterThan(TestNumberData.INTEGER_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Integer_Zero_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_ZERO.IsGreaterThan(TestNumberData.INTEGER_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Integer_PositiveTwo_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_POSITIVE_TWO.IsGreaterThan(TestNumberData.INTEGER_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThan_Zero_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_POSITIVE_TWO.IsGreaterThan(TestNumberData.INTEGER_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Integer_PositiveTwo_IsGreaterThan_PositiveOne_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_POSITIVE_TWO.IsGreaterThan(TestNumberData.INTEGER_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Number_Validation_Integer_PositiveTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_POSITIVE_TWO.IsGreaterThan(TestNumberData.INTEGER_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_NegativeTwo_IsGreaterThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_NEGATIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_NegativeTwo_IsGreaterThan_NegativeOne_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_NEGATIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Number_Validation_Decimal_NegativeTwo_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_NEGATIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_NegativeTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_NEGATIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_Zero_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_ZERO.IsGreaterThan(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_Zero_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_ZERO.IsGreaterThan(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_Zero_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_ZERO.IsGreaterThan(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_PositiveTwo_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_POSITIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_PositiveTwo_IsGreaterThan_Zero_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_POSITIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Decimal_PositiveTwo_IsGreaterThan_PositiveOne_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_POSITIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Number_Validation_Decimal_PositiveTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_POSITIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Float_NegativeTwo_IsGreaterThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_NEGATIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Float_NegativeTwo_IsGreaterThan_NegativeOne_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_NEGATIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Number_Validation_Float_NegativeTwo_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_NEGATIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Float_NegativeTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_NEGATIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Float_Zero_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_ZERO.IsGreaterThan(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Float_Zero_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_ZERO.IsGreaterThan(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Float_Zero_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_ZERO.IsGreaterThan(TestNumberData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Float_PositiveTwo_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_POSITIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Float_PositiveTwo_IsGreaterThan_Zero_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_POSITIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Float_PositiveTwo_IsGreaterThan_PositiveOne_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_POSITIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Number_Validation_Float_PositiveTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_POSITIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_POSITIVE_TWO));
		}
	}
}