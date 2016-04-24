using MasterExtensionKit.Numerics.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Numerics.UnitTests.Validations
{
	public class IsGreaterThanOrEqualExtensionTests
	{
		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.INT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThanOrEqual_NegativeOne_False()
		{
			Assert.IsFalse(TestData.INT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestData.INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestData.INT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.INT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.INT_ZERO.IsGreaterThanOrEqual(TestData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestData.INT_ZERO.IsGreaterThanOrEqual(TestData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.INT_ZERO.IsGreaterThanOrEqual(TestData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.INT_POSITIVE_TWO.IsGreaterThanOrEqual(TestData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestData.INT_POSITIVE_TWO.IsGreaterThanOrEqual(TestData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThanOrEqual_PositiveOne_True()
		{
			Assert.IsTrue(TestData.INT_POSITIVE_TWO.IsGreaterThanOrEqual(TestData.INT_POSITIVE_ONE));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.INT_POSITIVE_TWO.IsGreaterThanOrEqual(TestData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.DECIMAL_NEGATIVE_TWO.IsGreaterThanOrEqual(TestData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThanOrEqual_NegativeOne_False()
		{
			Assert.IsFalse(TestData.DECIMAL_NEGATIVE_TWO.IsGreaterThanOrEqual(TestData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestData.DECIMAL_NEGATIVE_TWO.IsGreaterThanOrEqual(TestData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.DECIMAL_NEGATIVE_TWO.IsGreaterThanOrEqual(TestData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.DECIMAL_ZERO.IsGreaterThanOrEqual(TestData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestData.DECIMAL_ZERO.IsGreaterThanOrEqual(TestData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.DECIMAL_ZERO.IsGreaterThanOrEqual(TestData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.DECIMAL_POSITIVE_TWO.IsGreaterThanOrEqual(TestData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestData.DECIMAL_POSITIVE_TWO.IsGreaterThanOrEqual(TestData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThanOrEqual_PositiveOne_True()
		{
			Assert.IsTrue(TestData.DECIMAL_POSITIVE_TWO.IsGreaterThanOrEqual(TestData.DECIMAL_POSITIVE_ONE));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.DECIMAL_POSITIVE_TWO.IsGreaterThanOrEqual(TestData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.FLOAT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThanOrEqual_NegativeOne_False()
		{
			Assert.IsFalse(TestData.FLOAT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestData.FLOAT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.FLOAT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.FLOAT_ZERO.IsGreaterThanOrEqual(TestData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestData.FLOAT_ZERO.IsGreaterThanOrEqual(TestData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.FLOAT_ZERO.IsGreaterThanOrEqual(TestData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.FLOAT_POSITIVE_TWO.IsGreaterThanOrEqual(TestData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestData.FLOAT_POSITIVE_TWO.IsGreaterThanOrEqual(TestData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThanOrEqual_PositiveOne_True()
		{
			Assert.IsTrue(TestData.FLOAT_POSITIVE_TWO.IsGreaterThanOrEqual(TestData.FLOAT_POSITIVE_ONE));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.FLOAT_POSITIVE_TWO.IsGreaterThanOrEqual(TestData.FLOAT_POSITIVE_TWO));
		}
	}
}