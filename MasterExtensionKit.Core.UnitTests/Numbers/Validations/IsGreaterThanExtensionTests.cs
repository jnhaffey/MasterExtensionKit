using MasterExtensionKit.Core.Numbers.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Numbers.Validations
{
	public class IsGreaterThanExtensionTests
	{
		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.INT_NEGATIVE_TWO.IsGreaterThan(TestNumberData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThan_NegativeOne_False()
		{
			Assert.IsFalse(TestNumberData.INT_NEGATIVE_TWO.IsGreaterThan(TestNumberData.INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.INT_NEGATIVE_TWO.IsGreaterThan(TestNumberData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.INT_NEGATIVE_TWO.IsGreaterThan(TestNumberData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.INT_ZERO.IsGreaterThan(TestNumberData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.INT_ZERO.IsGreaterThan(TestNumberData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.INT_ZERO.IsGreaterThan(TestNumberData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.INT_POSITIVE_TWO.IsGreaterThan(TestNumberData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThan_Zero_True()
		{
			Assert.IsTrue(TestNumberData.INT_POSITIVE_TWO.IsGreaterThan(TestNumberData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThan_PositiveOne_True()
		{
			Assert.IsTrue(TestNumberData.INT_POSITIVE_TWO.IsGreaterThan(TestNumberData.INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.INT_POSITIVE_TWO.IsGreaterThan(TestNumberData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_NEGATIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThan_NegativeOne_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_NEGATIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_NEGATIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_NEGATIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_ZERO.IsGreaterThan(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_ZERO.IsGreaterThan(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_ZERO.IsGreaterThan(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_POSITIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThan_Zero_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_POSITIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThan_PositiveOne_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_POSITIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_POSITIVE_TWO.IsGreaterThan(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_NEGATIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThan_NegativeOne_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_NEGATIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_NEGATIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_NEGATIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_ZERO.IsGreaterThan(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_ZERO.IsGreaterThan(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_ZERO.IsGreaterThan(TestNumberData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_POSITIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThan_Zero_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_POSITIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThan_PositiveOne_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_POSITIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_POSITIVE_TWO.IsGreaterThan(TestNumberData.FLOAT_POSITIVE_TWO));
		}
	}
}