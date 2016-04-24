using MasterExtensionKit.Numerics.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Numerics.UnitTests.Validations
{
	public class IsEvenExtensionTests
	{
		[TestMethod]
		public void IsEven_Integer_NegativeTwo_True()
		{
			Assert.IsTrue(TestData.INT_NEGATIVE_TWO.IsEven());
		}

		[TestMethod]
		public void IsEven_Integer_NegativeOne_False()
		{
			Assert.IsFalse(TestData.INT_NEGATIVE_ONE.IsEven());
		}

		[TestMethod]
		public void IsEven_Integer_Zero_True()
		{
			Assert.IsTrue(TestData.INT_ZERO.IsEven());
		}

		[TestMethod]
		public void IsEven_Integer_PositiveOne_False()
		{
			Assert.IsFalse(TestData.INT_POSITIVE_ONE.IsEven());
		}

		[TestMethod]
		public void IsEven_Integer_PositiveTwo_True()
		{
			Assert.IsTrue(TestData.INT_POSITIVE_TWO.IsEven());
		}
	}
}