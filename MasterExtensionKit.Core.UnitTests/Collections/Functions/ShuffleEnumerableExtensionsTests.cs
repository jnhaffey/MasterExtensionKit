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
		[TestMethod]
		public void Collection_Function_Shuffle_ListDoesNotMatch()
		{
			var shuffledList = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_FIVE.Shuffle();
			Assert.AreNotEqual(TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_FIVE, shuffledList);
		}

		[TestMethod]
		public void Collection_Function_Shuffle_ListCountMatch()
		{
			var shuffledList = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_FIVE.Shuffle();
			Assert.AreEqual(TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_FIVE.Count(), shuffledList.Count());
		}
	}
}