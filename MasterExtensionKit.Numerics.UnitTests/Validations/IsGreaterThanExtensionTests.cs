using MasterExtensionKit.Numerics.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Numerics.UnitTests.Validations
{
	public class IsGreaterThanExtensionTests
	{
		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.INT_NEGATIVE_TWO.IsGreaterThan(TestData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThan_NegativeOne_False()
		{
			Assert.IsFalse(TestData.INT_NEGATIVE_TWO.IsGreaterThan(TestData.INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestData.INT_NEGATIVE_TWO.IsGreaterThan(TestData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.INT_NEGATIVE_TWO.IsGreaterThan(TestData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.INT_ZERO.IsGreaterThan(TestData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestData.INT_ZERO.IsGreaterThan(TestData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.INT_ZERO.IsGreaterThan(TestData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.INT_POSITIVE_TWO.IsGreaterThan(TestData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThan_Zero_True()
		{
			Assert.IsTrue(TestData.INT_POSITIVE_TWO.IsGreaterThan(TestData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThan_PositiveOne_True()
		{
			Assert.IsTrue(TestData.INT_POSITIVE_TWO.IsGreaterThan(TestData.INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.INT_POSITIVE_TWO.IsGreaterThan(TestData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.DECIMAL_NEGATIVE_TWO.IsGreaterThan(TestData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThan_NegativeOne_False()
		{
			Assert.IsFalse(TestData.DECIMAL_NEGATIVE_TWO.IsGreaterThan(TestData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestData.DECIMAL_NEGATIVE_TWO.IsGreaterThan(TestData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.DECIMAL_NEGATIVE_TWO.IsGreaterThan(TestData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.DECIMAL_ZERO.IsGreaterThan(TestData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestData.DECIMAL_ZERO.IsGreaterThan(TestData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.DECIMAL_ZERO.IsGreaterThan(TestData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.DECIMAL_POSITIVE_TWO.IsGreaterThan(TestData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThan_Zero_True()
		{
			Assert.IsTrue(TestData.DECIMAL_POSITIVE_TWO.IsGreaterThan(TestData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThan_PositiveOne_True()
		{
			Assert.IsTrue(TestData.DECIMAL_POSITIVE_TWO.IsGreaterThan(TestData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.DECIMAL_POSITIVE_TWO.IsGreaterThan(TestData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.FLOAT_NEGATIVE_TWO.IsGreaterThan(TestData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThan_NegativeOne_False()
		{
			Assert.IsFalse(TestData.FLOAT_NEGATIVE_TWO.IsGreaterThan(TestData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestData.FLOAT_NEGATIVE_TWO.IsGreaterThan(TestData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.FLOAT_NEGATIVE_TWO.IsGreaterThan(TestData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.FLOAT_ZERO.IsGreaterThan(TestData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestData.FLOAT_ZERO.IsGreaterThan(TestData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.FLOAT_ZERO.IsGreaterThan(TestData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.FLOAT_POSITIVE_TWO.IsGreaterThan(TestData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThan_Zero_True()
		{
			Assert.IsTrue(TestData.FLOAT_POSITIVE_TWO.IsGreaterThan(TestData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThan_PositiveOne_True()
		{
			Assert.IsTrue(TestData.FLOAT_POSITIVE_TWO.IsGreaterThan(TestData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.FLOAT_POSITIVE_TWO.IsGreaterThan(TestData.FLOAT_POSITIVE_TWO));
		}
	}
}