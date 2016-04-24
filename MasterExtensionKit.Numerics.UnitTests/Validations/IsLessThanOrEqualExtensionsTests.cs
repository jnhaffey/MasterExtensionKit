using MasterExtensionKit.Numerics.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Numerics.UnitTests.Validations
{
	[TestClass]
	public class IsLessThanOrEqualExtensionsTests
	{
		[TestMethod]
		public void Integer_NegativeTwo_IsLessThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.INT_NEGATIVE_TWO.IsLessThanOrEqual(TestData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThanOrEqual_NegativeOne_True()
		{
			Assert.IsTrue(TestData.INT_NEGATIVE_TWO.IsLessThanOrEqual(TestData.INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestData.INT_NEGATIVE_TWO.IsLessThanOrEqual(TestData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.INT_NEGATIVE_TWO.IsLessThanOrEqual(TestData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.INT_ZERO.IsLessThanOrEqual(TestData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestData.INT_ZERO.IsLessThanOrEqual(TestData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.INT_ZERO.IsLessThanOrEqual(TestData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.INT_POSITIVE_TWO.IsLessThanOrEqual(TestData.INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestData.INT_POSITIVE_TWO.IsLessThanOrEqual(TestData.INT_ZERO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThanOrEqual_PositiveOne_False()
		{
			Assert.IsFalse(TestData.INT_POSITIVE_TWO.IsLessThanOrEqual(TestData.INT_POSITIVE_ONE));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.INT_POSITIVE_TWO.IsLessThanOrEqual(TestData.INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(TestData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThanOrEqual_NegativeOne_True()
		{
			Assert.IsTrue(TestData.DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(TestData.DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestData.DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(TestData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(TestData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.DECIMAL_ZERO.IsLessThanOrEqual(TestData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestData.DECIMAL_ZERO.IsLessThanOrEqual(TestData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.DECIMAL_ZERO.IsLessThanOrEqual(TestData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(TestData.DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestData.DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(TestData.DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThanOrEqual_PositiveOne_False()
		{
			Assert.IsFalse(TestData.DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(TestData.DECIMAL_POSITIVE_ONE));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(TestData.DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(TestData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThanOrEqual_NegativeOne_True()
		{
			Assert.IsTrue(TestData.FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(TestData.FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestData.FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(TestData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(TestData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.FLOAT_ZERO.IsLessThanOrEqual(TestData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestData.FLOAT_ZERO.IsLessThanOrEqual(TestData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.FLOAT_ZERO.IsLessThanOrEqual(TestData.FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.FLOAT_POSITIVE_TWO.IsLessThanOrEqual(TestData.FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestData.FLOAT_POSITIVE_TWO.IsLessThanOrEqual(TestData.FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThanOrEqual_PositiveOne_False()
		{
			Assert.IsFalse(TestData.FLOAT_POSITIVE_TWO.IsLessThanOrEqual(TestData.FLOAT_POSITIVE_ONE));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.FLOAT_POSITIVE_TWO.IsLessThanOrEqual(TestData.FLOAT_POSITIVE_TWO));
		}
	}
}