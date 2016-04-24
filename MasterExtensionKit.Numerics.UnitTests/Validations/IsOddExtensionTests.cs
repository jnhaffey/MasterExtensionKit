using MasterExtensionKit.Numerics.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Numerics.UnitTests.Validations
{
	public class IsOddExtensionTests
	{
		[TestMethod]
		public void IsOdd_Integer_NegativeTwo_False()
		{
			Assert.IsFalse(TestData.INT_NEGATIVE_TWO.IsOdd());
		}

		[TestMethod]
		public void IsOdd_Integer_NegativeOne_True()
		{
			Assert.IsTrue(TestData.INT_NEGATIVE_ONE.IsOdd());
		}

		[TestMethod]
		public void IsOdd_Integer_Zero_False()
		{
			Assert.IsFalse(TestData.INT_ZERO.IsOdd());
		}

		[TestMethod]
		public void IsOdd_Integer_PositiveOne_True()
		{
			Assert.IsTrue(TestData.INT_POSITIVE_ONE.IsOdd());
		}

		[TestMethod]
		public void IsOdd_Integer_PositiveTwo_False()
		{
			Assert.IsFalse(TestData.INT_POSITIVE_TWO.IsOdd());
		}
	}
}