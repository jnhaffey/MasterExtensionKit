using MasterExtensionKit.Numerics.Checks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Numerics.UnitTests.Checks
{
	[TestClass]
	public class IsCheckExtensionsTests
	{
		#region Integer Tests

		private const int INT_NEGATIVE_TWO = -2;
		private const int INT_NEGATIVE_ONE = -1;
		private const int INT_ZERO = 0;
		private const int INT_POSITIVE_ONE = 1;
		private const int INT_POSITIVE_TWO = 2;

		#region IsEven Tests

		[TestMethod]
		public void IsEven_Integer_NegativeTwo_True()
		{
			Assert.IsTrue(INT_NEGATIVE_TWO.IsEven());
		}

		[TestMethod]
		public void IsEven_Integer_NegativeOne_False()
		{
			Assert.IsFalse(INT_NEGATIVE_ONE.IsEven());
		}

		[TestMethod]
		public void IsEven_Integer_Zero_True()
		{
			Assert.IsTrue(INT_ZERO.IsEven());
		}

		[TestMethod]
		public void IsEven_Integer_PositiveOne_False()
		{
			Assert.IsFalse(INT_POSITIVE_ONE.IsEven());
		}

		[TestMethod]
		public void IsEven_Integer_PositiveTwo_True()
		{
			Assert.IsTrue(INT_POSITIVE_TWO.IsEven());
		}

		#endregion

		#region IsOdd Tests

		[TestMethod]
		public void IsOdd_Integer_NegativeTwo_False()
		{
			Assert.IsFalse(INT_NEGATIVE_TWO.IsOdd());
		}

		[TestMethod]
		public void IsOdd_Integer_NegativeOne_True()
		{
			Assert.IsTrue(INT_NEGATIVE_ONE.IsOdd());
		}

		[TestMethod]
		public void IsOdd_Integer_Zero_False()
		{
			Assert.IsFalse(INT_ZERO.IsOdd());
		}

		[TestMethod]
		public void IsOdd_Integer_PositiveOne_True()
		{
			Assert.IsTrue(INT_POSITIVE_ONE.IsOdd());
		}

		[TestMethod]
		public void IsOdd_Integer_PositiveTwo_False()
		{
			Assert.IsFalse(INT_POSITIVE_TWO.IsOdd());
		}

		#endregion

		#region IsGreaterThan Tests

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThan_NegativeTwo_False()
		{
			Assert.IsFalse(INT_NEGATIVE_TWO.IsGreaterThan(INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThan_NegativeOne_False()
		{
			Assert.IsFalse(INT_NEGATIVE_TWO.IsGreaterThan(INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(INT_NEGATIVE_TWO.IsGreaterThan(INT_ZERO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(INT_NEGATIVE_TWO.IsGreaterThan(INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(INT_ZERO.IsGreaterThan(INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(INT_ZERO.IsGreaterThan(INT_ZERO));
		}
		[TestMethod]
		public void Integer_Zero_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(INT_ZERO.IsGreaterThan(INT_POSITIVE_TWO));
		}
		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(INT_POSITIVE_TWO.IsGreaterThan(INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThan_Zero_True()
		{
			Assert.IsTrue(INT_POSITIVE_TWO.IsGreaterThan(INT_ZERO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThan_PositiveOne_True()
		{
			Assert.IsTrue(INT_POSITIVE_TWO.IsGreaterThan(INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(INT_POSITIVE_TWO.IsGreaterThan(INT_POSITIVE_TWO));
		}

		#endregion

		#region IsGreaterThanOrEqual Tests

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(INT_NEGATIVE_TWO.IsGreaterThanOrEqual(INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThanOrEqual_NegativeOne_False()
		{
			Assert.IsFalse(INT_NEGATIVE_TWO.IsGreaterThanOrEqual(INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThanOrEqual_Zero_False()
		{
			Assert.IsFalse(INT_NEGATIVE_TWO.IsGreaterThanOrEqual(INT_ZERO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(INT_NEGATIVE_TWO.IsGreaterThanOrEqual(INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(INT_ZERO.IsGreaterThanOrEqual(INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(INT_ZERO.IsGreaterThanOrEqual(INT_ZERO));
		}

		[TestMethod]
		public void Integer_Zero_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(INT_ZERO.IsGreaterThanOrEqual(INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(INT_POSITIVE_TWO.IsGreaterThanOrEqual(INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(INT_POSITIVE_TWO.IsGreaterThanOrEqual(INT_ZERO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThanOrEqual_PositiveOne_True()
		{
			Assert.IsTrue(INT_POSITIVE_TWO.IsGreaterThanOrEqual(INT_POSITIVE_ONE));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsGreaterThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(INT_POSITIVE_TWO.IsGreaterThanOrEqual(INT_POSITIVE_TWO));
		}

		#endregion

		#region IsLessThan Tests

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(INT_NEGATIVE_TWO.IsLessThan(INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThan_NegativeOne_True()
		{
			Assert.IsTrue(INT_NEGATIVE_TWO.IsLessThan(INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThan_Zero_True()
		{
			Assert.IsTrue(INT_NEGATIVE_TWO.IsLessThan(INT_ZERO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(INT_NEGATIVE_TWO.IsLessThan(INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(INT_ZERO.IsLessThan(INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThan_Zero_False()
		{
			Assert.IsFalse(INT_ZERO.IsLessThan(INT_ZERO));
		}
		[TestMethod]
		public void Integer_Zero_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(INT_ZERO.IsLessThan(INT_POSITIVE_TWO));
		}
		[TestMethod]
		public void Integer_PositiveTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(INT_POSITIVE_TWO.IsLessThan(INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThan_Zero_False()
		{
			Assert.IsFalse(INT_POSITIVE_TWO.IsLessThan(INT_ZERO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThan_PositiveOne_False()
		{
			Assert.IsFalse(INT_POSITIVE_TWO.IsLessThan(INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThan_PositiveTwo_False()
		{
			Assert.IsFalse(INT_POSITIVE_TWO.IsLessThan(INT_POSITIVE_TWO));
		}

		#endregion

		#region IsLessThanOrEqual Tests

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(INT_NEGATIVE_TWO.IsLessThanOrEqual(INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThanOrEqual_NegativeOne_True()
		{
			Assert.IsTrue(INT_NEGATIVE_TWO.IsLessThanOrEqual(INT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(INT_NEGATIVE_TWO.IsLessThanOrEqual(INT_ZERO));
		}

		[TestMethod]
		public void Integer_NegativeTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(INT_NEGATIVE_TWO.IsLessThanOrEqual(INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(INT_ZERO.IsLessThanOrEqual(INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(INT_ZERO.IsLessThanOrEqual(INT_ZERO));
		}

		[TestMethod]
		public void Integer_Zero_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(INT_ZERO.IsLessThanOrEqual(INT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(INT_POSITIVE_TWO.IsLessThanOrEqual(INT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThanOrEqual_Zero_False()
		{
			Assert.IsFalse(INT_POSITIVE_TWO.IsLessThanOrEqual(INT_ZERO));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThanOrEqual_PositiveOne_False()
		{
			Assert.IsFalse(INT_POSITIVE_TWO.IsLessThanOrEqual(INT_POSITIVE_ONE));
		}

		[TestMethod]
		public void Integer_PositiveTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(INT_POSITIVE_TWO.IsLessThanOrEqual(INT_POSITIVE_TWO));
		}

		#endregion

		#endregion

		#region Decimal Tests

		private const decimal DECIMAL_NEGATIVE_TWO = -2.0M;
		private const decimal DECIMAL_NEGATIVE_ONE = -1.0M;
		private const decimal DECIMAL_ZERO = 0.0M;
		private const decimal DECIMAL_POSITIVE_ONE = 1.0M;
		private const decimal DECIMAL_POSITIVE_TWO = 2.0M;

		#region IsGreaterThan Tests

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThan_NegativeTwo_False()
		{
			Assert.IsFalse(DECIMAL_NEGATIVE_TWO.IsGreaterThan(DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThan_NegativeOne_False()
		{
			Assert.IsFalse(DECIMAL_NEGATIVE_TWO.IsGreaterThan(DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(DECIMAL_NEGATIVE_TWO.IsGreaterThan(DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(DECIMAL_NEGATIVE_TWO.IsGreaterThan(DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(DECIMAL_ZERO.IsGreaterThan(DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(DECIMAL_ZERO.IsGreaterThan(DECIMAL_ZERO));
		}
		[TestMethod]
		public void Decimal_Zero_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(DECIMAL_ZERO.IsGreaterThan(DECIMAL_POSITIVE_TWO));
		}
		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(DECIMAL_POSITIVE_TWO.IsGreaterThan(DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThan_Zero_True()
		{
			Assert.IsTrue(DECIMAL_POSITIVE_TWO.IsGreaterThan(DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThan_PositiveOne_True()
		{
			Assert.IsTrue(DECIMAL_POSITIVE_TWO.IsGreaterThan(DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(DECIMAL_POSITIVE_TWO.IsGreaterThan(DECIMAL_POSITIVE_TWO));
		}

		#endregion

		#region IsGreaterThanOrEqual Tests

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(DECIMAL_NEGATIVE_TWO.IsGreaterThanOrEqual(DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThanOrEqual_NegativeOne_False()
		{
			Assert.IsFalse(DECIMAL_NEGATIVE_TWO.IsGreaterThanOrEqual(DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThanOrEqual_Zero_False()
		{
			Assert.IsFalse(DECIMAL_NEGATIVE_TWO.IsGreaterThanOrEqual(DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(DECIMAL_NEGATIVE_TWO.IsGreaterThanOrEqual(DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(DECIMAL_ZERO.IsGreaterThanOrEqual(DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(DECIMAL_ZERO.IsGreaterThanOrEqual(DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_Zero_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(DECIMAL_ZERO.IsGreaterThanOrEqual(DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(DECIMAL_POSITIVE_TWO.IsGreaterThanOrEqual(DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(DECIMAL_POSITIVE_TWO.IsGreaterThanOrEqual(DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThanOrEqual_PositiveOne_True()
		{
			Assert.IsTrue(DECIMAL_POSITIVE_TWO.IsGreaterThanOrEqual(DECIMAL_POSITIVE_ONE));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsGreaterThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(DECIMAL_POSITIVE_TWO.IsGreaterThanOrEqual(DECIMAL_POSITIVE_TWO));
		}

		#endregion

		#region IsLessThan Tests

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(DECIMAL_NEGATIVE_TWO.IsLessThan(DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThan_NegativeOne_True()
		{
			Assert.IsTrue(DECIMAL_NEGATIVE_TWO.IsLessThan(DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThan_Zero_True()
		{
			Assert.IsTrue(DECIMAL_NEGATIVE_TWO.IsLessThan(DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(DECIMAL_NEGATIVE_TWO.IsLessThan(DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(DECIMAL_ZERO.IsLessThan(DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThan_Zero_False()
		{
			Assert.IsFalse(DECIMAL_ZERO.IsLessThan(DECIMAL_ZERO));
		}
		[TestMethod]
		public void Decimal_Zero_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(DECIMAL_ZERO.IsLessThan(DECIMAL_POSITIVE_TWO));
		}
		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(DECIMAL_POSITIVE_TWO.IsLessThan(DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThan_Zero_False()
		{
			Assert.IsFalse(DECIMAL_POSITIVE_TWO.IsLessThan(DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThan_PositiveOne_False()
		{
			Assert.IsFalse(DECIMAL_POSITIVE_TWO.IsLessThan(DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThan_PositiveTwo_False()
		{
			Assert.IsFalse(DECIMAL_POSITIVE_TWO.IsLessThan(DECIMAL_POSITIVE_TWO));
		}

		#endregion

		#region IsLessThanOrEqual Tests

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThanOrEqual_NegativeOne_True()
		{
			Assert.IsTrue(DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(DECIMAL_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_NegativeTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(DECIMAL_NEGATIVE_TWO.IsLessThanOrEqual(DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(DECIMAL_ZERO.IsLessThanOrEqual(DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(DECIMAL_ZERO.IsLessThanOrEqual(DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_Zero_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(DECIMAL_ZERO.IsLessThanOrEqual(DECIMAL_POSITIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(DECIMAL_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThanOrEqual_Zero_False()
		{
			Assert.IsFalse(DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(DECIMAL_ZERO));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThanOrEqual_PositiveOne_False()
		{
			Assert.IsFalse(DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(DECIMAL_POSITIVE_ONE));
		}

		[TestMethod]
		public void Decimal_PositiveTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(DECIMAL_POSITIVE_TWO.IsLessThanOrEqual(DECIMAL_POSITIVE_TWO));
		}

		#endregion

		#endregion

		#region Float Tests

		private const float FLOAT_NEGATIVE_TWO = -2.0F;
		private const float FLOAT_NEGATIVE_ONE = -1.0F;
		private const float FLOAT_ZERO = 0.0F;
		private const float FLOAT_POSITIVE_ONE = 1.0F;
		private const float FLOAT_POSITIVE_TWO = 2.0F;

		#region IsGreaterThan Tests

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThan_NegativeTwo_False()
		{
			Assert.IsFalse(FLOAT_NEGATIVE_TWO.IsGreaterThan(FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThan_NegativeOne_False()
		{
			Assert.IsFalse(FLOAT_NEGATIVE_TWO.IsGreaterThan(FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(FLOAT_NEGATIVE_TWO.IsGreaterThan(FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(FLOAT_NEGATIVE_TWO.IsGreaterThan(FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(FLOAT_ZERO.IsGreaterThan(FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThan_Zero_False()
		{
			Assert.IsFalse(FLOAT_ZERO.IsGreaterThan(FLOAT_ZERO));
		}
		[TestMethod]
		public void Float_Zero_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(FLOAT_ZERO.IsGreaterThan(FLOAT_POSITIVE_TWO));
		}
		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThan_NegativeTwo_True()
		{
			Assert.IsTrue(FLOAT_POSITIVE_TWO.IsGreaterThan(FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThan_Zero_True()
		{
			Assert.IsTrue(FLOAT_POSITIVE_TWO.IsGreaterThan(FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThan_PositiveOne_True()
		{
			Assert.IsTrue(FLOAT_POSITIVE_TWO.IsGreaterThan(FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThan_PositiveTwo_False()
		{
			Assert.IsFalse(FLOAT_POSITIVE_TWO.IsGreaterThan(FLOAT_POSITIVE_TWO));
		}

		#endregion

		#region IsGreaterThanOrEqual Tests

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(FLOAT_NEGATIVE_TWO.IsGreaterThanOrEqual(FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThanOrEqual_NegativeOne_False()
		{
			Assert.IsFalse(FLOAT_NEGATIVE_TWO.IsGreaterThanOrEqual(FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThanOrEqual_Zero_False()
		{
			Assert.IsFalse(FLOAT_NEGATIVE_TWO.IsGreaterThanOrEqual(FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(FLOAT_NEGATIVE_TWO.IsGreaterThanOrEqual(FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(FLOAT_ZERO.IsGreaterThanOrEqual(FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(FLOAT_ZERO.IsGreaterThanOrEqual(FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_Zero_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(FLOAT_ZERO.IsGreaterThanOrEqual(FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(FLOAT_POSITIVE_TWO.IsGreaterThanOrEqual(FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(FLOAT_POSITIVE_TWO.IsGreaterThanOrEqual(FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThanOrEqual_PositiveOne_True()
		{
			Assert.IsTrue(FLOAT_POSITIVE_TWO.IsGreaterThanOrEqual(FLOAT_POSITIVE_ONE));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsGreaterThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(FLOAT_POSITIVE_TWO.IsGreaterThanOrEqual(FLOAT_POSITIVE_TWO));
		}

		#endregion

		#region IsLessThan Tests

		[TestMethod]
		public void Float_NegativeTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(FLOAT_NEGATIVE_TWO.IsLessThan(FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThan_NegativeOne_True()
		{
			Assert.IsTrue(FLOAT_NEGATIVE_TWO.IsLessThan(FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThan_Zero_True()
		{
			Assert.IsTrue(FLOAT_NEGATIVE_TWO.IsLessThan(FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(FLOAT_NEGATIVE_TWO.IsLessThan(FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(FLOAT_ZERO.IsLessThan(FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThan_Zero_False()
		{
			Assert.IsFalse(FLOAT_ZERO.IsLessThan(FLOAT_ZERO));
		}
		[TestMethod]
		public void Float_Zero_IsLessThan_PositiveTwo_True()
		{
			Assert.IsTrue(FLOAT_ZERO.IsLessThan(FLOAT_POSITIVE_TWO));
		}
		[TestMethod]
		public void Float_PositiveTwo_IsLessThan_NegativeTwo_False()
		{
			Assert.IsFalse(FLOAT_POSITIVE_TWO.IsLessThan(FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThan_Zero_False()
		{
			Assert.IsFalse(FLOAT_POSITIVE_TWO.IsLessThan(FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThan_PositiveOne_False()
		{
			Assert.IsFalse(FLOAT_POSITIVE_TWO.IsLessThan(FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThan_PositiveTwo_False()
		{
			Assert.IsFalse(FLOAT_POSITIVE_TWO.IsLessThan(FLOAT_POSITIVE_TWO));
		}

		#endregion

		#region IsLessThanOrEqual Tests

		[TestMethod]
		public void Float_NegativeTwo_IsLessThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThanOrEqual_NegativeOne_True()
		{
			Assert.IsTrue(FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(FLOAT_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_NegativeTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(FLOAT_NEGATIVE_TWO.IsLessThanOrEqual(FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(FLOAT_ZERO.IsLessThanOrEqual(FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThanOrEqual_Zero_True()
		{
			Assert.IsTrue(FLOAT_ZERO.IsLessThanOrEqual(FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_Zero_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(FLOAT_ZERO.IsLessThanOrEqual(FLOAT_POSITIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThanOrEqual_NegativeTwo_False()
		{
			Assert.IsFalse(FLOAT_POSITIVE_TWO.IsLessThanOrEqual(FLOAT_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThanOrEqual_Zero_False()
		{
			Assert.IsFalse(FLOAT_POSITIVE_TWO.IsLessThanOrEqual(FLOAT_ZERO));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThanOrEqual_PositiveOne_False()
		{
			Assert.IsFalse(FLOAT_POSITIVE_TWO.IsLessThanOrEqual(FLOAT_POSITIVE_ONE));
		}

		[TestMethod]
		public void Float_PositiveTwo_IsLessThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(FLOAT_POSITIVE_TWO.IsLessThanOrEqual(FLOAT_POSITIVE_TWO));
		}

		#endregion

		#endregion
	}
}