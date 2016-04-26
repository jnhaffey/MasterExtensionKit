using System.Linq;
using MasterExtensionKit.Core.Collections.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Collections.Functions
{
	[TestClass]
	public class ShuffleEnumerableExtensionsTests
	{
		[TestMethod]
		public void Shuffle_ListDoesNotMatch()
		{
			var shuffledList = TestCollectionData.OrderNumbers.Shuffle();
			Assert.AreNotEqual(TestCollectionData.OrderNumbers, shuffledList);
		}

		[TestMethod]
		public void Shuffle_ListCountMatch()
		{
			var shuffledList = TestCollectionData.OrderNumbers.Shuffle();
			Assert.AreEqual(TestCollectionData.OrderNumbers.Count(), shuffledList.Count());
		}
	}
}