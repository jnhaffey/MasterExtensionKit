using MasterExtensionKit.Numerics.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Numerics.UnitTests.Validations
{
	public class IsLessThanExtensionTests
	{
		[TestMethod]
		public void Integer_NegativeTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.INT_NEGATIVE_TWO.IsLessThan(TestData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThan_NegativeOne_True()
		{
			Assert.IsTrue(TestData.INT_NEGATIVE_TWO.IsLessThan(TestData.INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThan_Zero_True()
		{
			Assert.IsTrue(TestData.INT_NEGATIVE_TWO.IsLessThan(TestData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.INT_NEGATIVE_TWO.IsLessThan(TestData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.INT_ZERO.IsLessThan(TestData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThan_Zero_False()
		{
			Assert.IsFalse(TestData.INT_ZERO.IsLessThan(TestData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.INT_ZERO.IsLessThan(TestData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.INT_POSITIVE_TWO.IsLessThan(TestData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThan_Zero_False()
		{
			Assert.IsFalse(TestData.INT_POSITIVE_TWO.IsLessThan(TestData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThan_PositiveOne_False()
		{
			Assert.IsFalse(TestData.INT_POSITIVE_TWO.IsLessThan(TestData.INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.INT_POSITIVE_TWO.IsLessThan(TestData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.DECIMAL_NEGATIVE_TWO.IsLessThan(TestData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThan_NegativeOne_True()
		{
			Assert.IsTrue(TestData.DECIMAL_NEGATIVE_TWO.IsLessThan(TestData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThan_Zero_True()
		{
			Assert.IsTrue(TestData.DECIMAL_NEGATIVE_TWO.IsLessThan(TestData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.DECIMAL_NEGATIVE_TWO.IsLessThan(TestData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.DECIMAL_ZERO.IsLessThan(TestData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThan_Zero_False()
		{
			Assert.IsFalse(TestData.DECIMAL_ZERO.IsLessThan(TestData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.DECIMAL_ZERO.IsLessThan(TestData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.DECIMAL_POSITIVE_TWO.IsLessThan(TestData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThan_Zero_False()
		{
			Assert.IsFalse(TestData.DECIMAL_POSITIVE_TWO.IsLessThan(TestData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThan_PositiveOne_False()
		{
			Assert.IsFalse(TestData.DECIMAL_POSITIVE_TWO.IsLessThan(TestData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.DECIMAL_POSITIVE_TWO.IsLessThan(TestData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.FLOAT_NEGATIVE_TWO.IsLessThan(TestData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThan_NegativeOne_True()
		{
			Assert.IsTrue(TestData.FLOAT_NEGATIVE_TWO.IsLessThan(TestData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThan_Zero_True()
		{
			Assert.IsTrue(TestData.FLOAT_NEGATIVE_TWO.IsLessThan(TestData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.FLOAT_NEGATIVE_TWO.IsLessThan(TestData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.FLOAT_ZERO.IsLessThan(TestData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThan_Zero_False()
		{
			Assert.IsFalse(TestData.FLOAT_ZERO.IsLessThan(TestData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.FLOAT_ZERO.IsLessThan(TestData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.FLOAT_POSITIVE_TWO.IsLessThan(TestData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThan_Zero_False()
		{
			Assert.IsFalse(TestData.FLOAT_POSITIVE_TWO.IsLessThan(TestData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThan_PositiveOne_False()
		{
			Assert.IsFalse(TestData.FLOAT_POSITIVE_TWO.IsLessThan(TestData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.FLOAT_POSITIVE_TWO.IsLessThan(TestData.FLOAT_POSITIVE_TWO));
		}
	}
}