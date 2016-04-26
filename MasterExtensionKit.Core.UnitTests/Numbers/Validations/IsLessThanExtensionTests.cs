using MasterExtensionKit.Core.Numbers.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Numbers.Validations
{
	public class IsLessThanExtensionTests
	{
		[TestMethod]
		public void Integer_NegativeTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.INT_NEGATIVE_TWO.IsLessThan(TestNumberData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThan_NegativeOne_True()
		{
			Assert.IsTrue(TestNumberData.INT_NEGATIVE_TWO.IsLessThan(TestNumberData.INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThan_Zero_True()
		{
			Assert.IsTrue(TestNumberData.INT_NEGATIVE_TWO.IsLessThan(TestNumberData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.INT_NEGATIVE_TWO.IsLessThan(TestNumberData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.INT_ZERO.IsLessThan(TestNumberData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.INT_ZERO.IsLessThan(TestNumberData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.INT_ZERO.IsLessThan(TestNumberData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.INT_POSITIVE_TWO.IsLessThan(TestNumberData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.INT_POSITIVE_TWO.IsLessThan(TestNumberData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThan_PositiveOne_False()
		{
			Assert.IsFalse(TestNumberData.INT_POSITIVE_TWO.IsLessThan(TestNumberData.INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.INT_POSITIVE_TWO.IsLessThan(TestNumberData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_NEGATIVE_TWO.IsLessThan(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThan_NegativeOne_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_NEGATIVE_TWO.IsLessThan(TestNumberData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThan_Zero_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_NEGATIVE_TWO.IsLessThan(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_NEGATIVE_TWO.IsLessThan(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_ZERO.IsLessThan(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_ZERO.IsLessThan(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.DECIMAL_ZERO.IsLessThan(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_POSITIVE_TWO.IsLessThan(TestNumberData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_POSITIVE_TWO.IsLessThan(TestNumberData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThan_PositiveOne_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_POSITIVE_TWO.IsLessThan(TestNumberData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.DECIMAL_POSITIVE_TWO.IsLessThan(TestNumberData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_NEGATIVE_TWO.IsLessThan(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThan_NegativeOne_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_NEGATIVE_TWO.IsLessThan(TestNumberData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThan_Zero_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_NEGATIVE_TWO.IsLessThan(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_NEGATIVE_TWO.IsLessThan(TestNumberData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_ZERO.IsLessThan(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_ZERO.IsLessThan(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.FLOAT_ZERO.IsLessThan(TestNumberData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_POSITIVE_TWO.IsLessThan(TestNumberData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThan_Zero_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_POSITIVE_TWO.IsLessThan(TestNumberData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThan_PositiveOne_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_POSITIVE_TWO.IsLessThan(TestNumberData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThan_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.FLOAT_POSITIVE_TWO.IsLessThan(TestNumberData.FLOAT_POSITIVE_TWO));
		}
	}
}