using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Numbers.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Numbers.Validations
{
	public class IsGreaterThanOrEqualExtensionTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Number_Validation_IsGreaterThanOrEqual_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Number_Validation_IsGreaterThanOrEqual_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion

		[TestMethod]
		public void Number_Validation_Number_Validation_Integer_NegativeTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INTEGER_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Number_Validation_Integer_NegativeTwo_IsGreaterThanOrEqual_NegativeOne_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INTEGER_NEGATIVE_ONE));
		}

		[TestMethod]
		public void Number_Validation_Integer_NegativeTwo_IsGreaterThanOrEqual_Zero_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INTEGER_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Integer_NegativeTwo_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_NEGATIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INTEGER_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Integer_Zero_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_ZERO.IsGreaterThanOrEqual(TestNumberData.INTEGER_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Integer_Zero_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_ZERO.IsGreaterThanOrEqual(TestNumberData.INTEGER_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Integer_Zero_IsGreaterThanOrEqual_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.INTEGER_ZERO.IsGreaterThanOrEqual(TestNumberData.INTEGER_POSITIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Integer_PositiveTwo_IsGreaterThanOrEqual_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INTEGER_NEGATIVE_TWO));
		}

		[TestMethod]
		public void Number_Validation_Integer_PositiveTwo_IsGreaterThanOrEqual_Zero_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INTEGER_ZERO));
		}

		[TestMethod]
		public void Number_Validation_Integer_PositiveTwo_IsGreaterThanOrEqual_PositiveOne_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INTEGER_POSITIVE_ONE));
		}

		[TestMethod]
		public void Number_Validation_Integer_PositiveTwo_IsGreaterThanOrEqual_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.INTEGER_POSITIVE_TWO.IsGreaterThanOrEqual(TestNumberData.INTEGER_POSITIVE_TWO));
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