using System;
using System.Collections.Generic;
using System.Linq;
using MasterExtensionKit.Core.Collections.Functions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Models;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Collections.Functions
{
	[TestClass]
	public class CompareExtensionUnitTests
	{
		#region General Collection Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Collection_Function_Compare_Null_Exception()
		{
			TestCollectionData.NULL_LIST.Compare(TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN);
		}

		[TestMethod]
		public void Collection_Function_Compare_Empty_ReturnType_EnumerableCompareResults_Valid()
		{
			var actualResults = TestCollectionData.EMPTY_LIST.Compare(TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN);
			Assert.IsInstanceOfType(actualResults, typeof(CollectionCompareResults<int>));
		}

		[TestMethod]
		public void Collection_Function_Compare_Empty_First_Collection_Correct_EnumerableCompareResults_Valid()
		{
			var expectedResults =
				new CollectionCompareResults<int>(missingSorceRecords: TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN,
					missingSecondaryRecords: new List<int>());
			var actualResults = TestCollectionData.EMPTY_LIST.Compare(TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSourceCollection.ToList(), actualResults.RecordsMissingInSourceCollection.ToList());
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSecondaryCollection.ToList(), actualResults.RecordsMissingInSecondaryCollection.ToList());
		}

		[TestMethod]
		public void Collection_Function_Compare_Empty_Second_Collection_Correct_EnumerableCompareResults_Valid()
		{
			var expectedResults = new CollectionCompareResults<int>(missingSorceRecords: new List<int>(),
				missingSecondaryRecords: TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN);
			var actualResults = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN.Compare(TestCollectionData.EMPTY_LIST);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSourceCollection.ToList(), actualResults.RecordsMissingInSourceCollection.ToList());
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSecondaryCollection.ToList(), actualResults.RecordsMissingInSecondaryCollection.ToList());
		}

		#endregion

		[TestMethod]
		public void Collection_Function_Compare_TwoCollections_ExactMatch_Valid()
		{
			var expectedResults = new CollectionCompareResults<int>(missingSorceRecords: new List<int>(), missingSecondaryRecords: new List<int>());
			var actualResults = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN.Compare(TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSourceCollection.ToList(), actualResults.RecordsMissingInSourceCollection.ToList());
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSecondaryCollection.ToList(), actualResults.RecordsMissingInSecondaryCollection.ToList());
		}

		[TestMethod]
		public void Collection_Function_Compare_TwoCollections_SecondCollectionMissing_Six_Thru_Ten_Valid()
		{
			var expectedResults = new CollectionCompareResults<int>(missingSorceRecords: new List<int>(), missingSecondaryRecords: TestCollectionData.ORDER_OF_NUMBERS_SIX_THRU_TEN);
			var actualResults = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN.Compare(TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_FIVE);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSourceCollection.ToList(), actualResults.RecordsMissingInSourceCollection.ToList());
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSecondaryCollection.ToList(), actualResults.RecordsMissingInSecondaryCollection.ToList());
		}

		[TestMethod]
		public void Collection_Function_Compare_TwoCollections_FirstCollectionMissing_Six_Thru_Ten_Valid()
		{
			var expectedResults = new CollectionCompareResults<int>(missingSorceRecords: TestCollectionData.ORDER_OF_NUMBERS_SIX_THRU_TEN, missingSecondaryRecords: new List<int>());
			var actualResults = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_FIVE.Compare(TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSourceCollection.ToList(), actualResults.RecordsMissingInSourceCollection.ToList());
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSecondaryCollection.ToList(), actualResults.RecordsMissingInSecondaryCollection.ToList());
		}

		[TestMethod]
		public void Collection_Function_Compare_TwoCollections_FirstCollectionMissing_Six_Thru_Ten_SecondCollectionMissing_One_Thru_Five_Valid()
		{
			var expectedResults = new CollectionCompareResults<int>(missingSorceRecords: TestCollectionData.ORDER_OF_NUMBERS_SIX_THRU_TEN, missingSecondaryRecords: TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_FIVE);
			var actualResults = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_FIVE.Compare(TestCollectionData.ORDER_OF_NUMBERS_SIX_THRU_TEN);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSourceCollection.ToList(), actualResults.RecordsMissingInSourceCollection.ToList());
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSecondaryCollection.ToList(), actualResults.RecordsMissingInSecondaryCollection.ToList());
		}
	}
}
