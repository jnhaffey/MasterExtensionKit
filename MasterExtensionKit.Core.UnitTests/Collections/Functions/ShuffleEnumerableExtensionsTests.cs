using System.Linq;
using MasterExtensionKit.Core.Collections.Functions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Collections.Functions
{
	[TestClass]
	public class ShuffleEnumerableExtensionsTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Collection_Function_Shuffle_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Collection_Function_Shuffle_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion

		[TestMethod]
		public void Collection_Function_Shuffle_ListDoesNotMatch()
		{
			var shuffledList = TestCollectionData.ORDER_OF_NUMBERS_1_THRU_5.Shuffle();
			Assert.AreNotEqual(TestCollectionData.ORDER_OF_NUMBERS_1_THRU_5, shuffledList);
		}

		[TestMethod]
		public void Collection_Function_Shuffle_ListCountMatch()
		{
			var shuffledList = TestCollectionData.ORDER_OF_NUMBERS_1_THRU_5.Shuffle();
			Assert.AreEqual(TestCollectionData.ORDER_OF_NUMBERS_1_THRU_5.Count(), shuffledList.Count());
		}
	}
}