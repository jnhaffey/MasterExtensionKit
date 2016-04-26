using MasterExtensionKit.Core.Numbers.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Numbers.Validations
{
	public class IsOddExtensionTests
	{
		[TestMethod]
		public void IsOdd_Integer_NegativeTwo_False()
		{
			Assert.IsFalse(TestNumberData.INT_NEGATIVE_TWO.IsOdd());
		}

		[TestMethod]
		public void IsOdd_Integer_NegativeOne_True()
		{
			Assert.IsTrue(TestNumberData.INT_NEGATIVE_ONE.IsOdd());
		}

		[TestMethod]
		public void IsOdd_Integer_Zero_False()
		{
			Assert.IsFalse(TestNumberData.INT_ZERO.IsOdd());
		}

		[TestMethod]
		public void IsOdd_Integer_PositiveOne_True()
		{
			Assert.IsTrue(TestNumberData.INT_POSITIVE_ONE.IsOdd());
		}

		[TestMethod]
		public void IsOdd_Integer_PositiveTwo_False()
		{
			Assert.IsFalse(TestNumberData.INT_POSITIVE_TWO.IsOdd());
		}
	}
}