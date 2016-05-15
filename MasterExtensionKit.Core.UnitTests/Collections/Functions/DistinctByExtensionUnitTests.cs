using System.Collections.Generic;
using System.Linq;
using MasterExtensionKit.Core.Collections.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Collections.Functions
{
	[TestClass]
	public class DistinctByExtensionUnitTests
	{
		[TestMethod]
		public void Collection_Function_DistinctBy_ListOfNumbers_SomeDuplicates_ReturnsSignalsList()
		{
			var modifiedTestData = new List<int>();
			modifiedTestData.AddRange(TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN);
			modifiedTestData.AddRange(TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_FIVE);

			var actualResult = modifiedTestData.DistinctBy(m => m).ToList();

			CollectionAssert.AreEquivalent(TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN, actualResult);
		}
	}
}