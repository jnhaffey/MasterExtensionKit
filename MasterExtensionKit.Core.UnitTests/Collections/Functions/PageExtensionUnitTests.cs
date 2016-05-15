using System.Collections.Generic;
using System.Linq;
using MasterExtensionKit.Core.Collections.Functions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Collections.Functions
{
	[TestClass]
	public class PageExtensionUnitTests
	{
		[TestMethod]
		public void Collection_Function_Page_DefaultValues_Count_Valid()
		{
			var actualResult = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN.Page();
			Assert.AreEqual(TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN.Count, actualResult.Count());
		}

		[TestMethod]
		public void Collection_Function_Page_DefaultValues_Collection_Valid()
		{
			var actualResult = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN.Page();
			CollectionAssert.AreEqual(TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN, actualResult.ToList());
		}

		[TestMethod]
		[ExpectedException(typeof(PageOutOfRangeException), "")]
		public void Collection_Function_Page_TenPerPage_Page2_OutOfRangeException()
		{
			TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN.Page(10, 2);
		}

		[TestMethod]
		public void Collection_Function_Page_TwoPerPage_PageOne_Count_Valid()
		{
			var actualResult = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN.Page(2);
			Assert.AreEqual(2, actualResult.Count());
		}

		[TestMethod]
		public void Collection_Function_Page_TwoPerPage_PageOne_Collection_Valid()
		{
			var expectedResult = new List<int> {1, 2};
			var actualResult = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN.Page(2);
			CollectionAssert.AreEqual(expectedResult, actualResult.ToList());
		}

		[TestMethod]
		public void Collection_Function_Page_TwoPerPage_PageTwo_Count_Valid()
		{
			var actualResult = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN.Page(2, 2);
			Assert.AreEqual(2, actualResult.Count());
		}

		[TestMethod]
		public void Collection_Function_Page_TwoPerPage_PageTwo_Collection_Valid()
		{
			var expectedResult = new List<int> {3, 4};
			var actualResult = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN.Page(2, 2);
			CollectionAssert.AreEqual(expectedResult, actualResult.ToList());
		}
	}
}