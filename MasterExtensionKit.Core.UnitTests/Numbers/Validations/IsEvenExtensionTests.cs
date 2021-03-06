using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Numbers.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Numbers.Validations
{
	public class IsEvenExtensionTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Number_Validation_IsEven_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Number_Validation_IsEven_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion

		[TestMethod]
		public void Number_Validation_IsEven_Integer_NegativeTwo_Valid()
		{
			Assert.IsTrue(TestNumberData.INTEGER_NEGATIVE_TWO.IsEven());
		}

		[TestMethod]
		public void Number_Validation_IsEven_Integer_NegativeOne_Invalid()
		{
			Assert.IsFalse(TestNumberData.INTEGER_NEGATIVE_ONE.IsEven());
		}

		[TestMethod]
		public void Number_Validation_IsEven_Integer_Zero_Valid()
		{
			Assert.IsTrue(TestNumberData.INTEGER_ZERO.IsEven());
		}

		[TestMethod]
		public void Number_Validation_IsEven_Integer_PositiveOne_Invalid()
		{
			Assert.IsFalse(TestNumberData.INTEGER_POSITIVE_ONE.IsEven());
		}

		[TestMethod]
		public void Number_Validation_IsEven_Integer_PositiveTwo_Valid()
		{
			Assert.IsTrue(TestNumberData.INTEGER_POSITIVE_TWO.IsEven());
		}
	}
}