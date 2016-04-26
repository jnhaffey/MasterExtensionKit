using MasterExtensionKit.Core.Numbers.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Numbers.Validations
{
	public class IsEvenExtensionTests
	{
		[TestMethod]
		public void IsEven_Integer_NegativeTwo_True()
		{
			Assert.IsTrue(TestNumberData.INT_NEGATIVE_TWO.IsEven());
		}

		[TestMethod]
		public void IsEven_Integer_NegativeOne_False()
		{
			Assert.IsFalse(TestNumberData.INT_NEGATIVE_ONE.IsEven());
		}

		[TestMethod]
		public void IsEven_Integer_Zero_True()
		{
			Assert.IsTrue(TestNumberData.INT_ZERO.IsEven());
		}

		[TestMethod]
		public void IsEven_Integer_PositiveOne_False()
		{
			Assert.IsFalse(TestNumberData.INT_POSITIVE_ONE.IsEven());
		}

		[TestMethod]
		public void IsEven_Integer_PositiveTwo_True()
		{
			Assert.IsTrue(TestNumberData.INT_POSITIVE_TWO.IsEven());
		}
	}
}