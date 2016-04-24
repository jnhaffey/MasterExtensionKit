using System.Linq;
using MasterExtensionKit.Collections.Functions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Collections.UnitTests.Functions
{
	[TestClass]
	public class ShuffleEnumerableExtensionsTests
	{
		[TestMethod]
		public void Shuffle_ListDoesNotMatch()
		{
			var shuffledList = TestData.OrderNumbers.Shuffle();
			Assert.AreNotEqual(TestData.OrderNumbers, shuffledList);
		}

		[TestMethod]
		public void Shuffle_ListCountMatch()
		{
			var shuffledList = TestData.OrderNumbers.Shuffle();
			Assert.AreEqual(TestData.OrderNumbers.Count(), shuffledList.Count());
		}
	}
}