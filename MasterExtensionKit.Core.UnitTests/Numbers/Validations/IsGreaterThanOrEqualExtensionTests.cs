using MasterExtensionKit.Core.Numbers.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Numbers.Validations
{
	public class IsGreaterThanOrEqualExtensionTests
	{
		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.INT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThanOrEqual_NegativeOne_False()
		{
			Assert.IsFalse(TestNumberData.INT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestNumberData.INT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.INT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.INT_ZERO.IsGreaterThanOrEqual(TestNumberData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.INT_ZERO.IsGreaterThanOrEqual(TestNumberData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.INT_ZERO.IsGreaterThanOrEqual(TestNumberData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.INT_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.INT_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThanOrEqual_PositiveOne_True()
		{
			Assert.IsTrue(TestNumberData.INT_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INT_POSITIVE_ONE));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.INT_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThanOrEqual_NegativeOne_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_ZERO.IsGreaterThanOrEqual(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_ZERO.IsGreaterThanOrEqual(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_ZERO.IsGreaterThanOrEqual(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThanOrEqual_PositiveOne_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.DECIMAL_POSITIVE_ONE));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThanOrEqual_NegativeOne_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_ZERO.IsGreaterThanOrEqual(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_ZERO.IsGreaterThanOrEqual(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_ZERO.IsGreaterThanOrEqual(TestNumberData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThanOrEqual_PositiveOne_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.FLOAT_POSITIVE_ONE));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.FLOAT_POSITIVE_TWO));
		}
	}
}