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
			TestCollectionData.NULL_LIST.Compare(TestCollectionData.ORDER_OF_NUMBERS_1_THRU_10);
		}

		[TestMethod]
		public void Collection_Function_Compare_Empty_ReturnType_EnumerableCompareResults_Valid()
		{
			var actualResults = TestCollectionData.EMPTY_LIST.Compare(TestCollectionData.ORDER_OF_NUMBERS_1_THRU_10);
			Assert.IsInstanceOfType(actualResults, typeof(CollectionCompareResults<int>));
		}

		[TestMethod]
		public void Collection_Function_Compare_Empty_First_Collection_Correct_EnumerableCompareResults_Valid()
		{
			var expectedResults = new CollectionCompareResults<int>
			{
				RecordsMissingInSourceCollection = TestCollectionData.ORDER_OF_NUMBERS_1_THRU_10,
				RecordsMissingInSecondaryCollection = new List<int>()
			};
			var actualResults = TestCollectionData.EMPTY_LIST.Compare(TestCollectionData.ORDER_OF_NUMBERS_1_THRU_10);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSourceCollection, actualResults.RecordsMissingInSourceCollection);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSecondaryCollection, actualResults.RecordsMissingInSecondaryCollection);
		}

		[TestMethod]
		public void Collection_Function_Compare_Empty_Second_Collection_Correct_EnumerableCompareResults_Valid()
		{
			var expectedResults = new CollectionCompareResults<int>
			{
				RecordsMissingInSourceCollection = new List<int>(),
				RecordsMissingInSecondaryCollection = TestCollectionData.ORDER_OF_NUMBERS_1_THRU_10
			};
			var actualResults = TestCollectionData.ORDER_OF_NUMBERS_1_THRU_10.Compare(TestCollectionData.EMPTY_LIST);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSourceCollection, actualResults.RecordsMissingInSourceCollection);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSecondaryCollection, actualResults.RecordsMissingInSecondaryCollection);
		}

		#endregion

		[TestMethod]
		public void Collection_Function_Compare_TwoCollections_ExactMatch_Valid()
		{
			var expectedResults = new CollectionCompareResults<int>
			{
				RecordsMissingInSourceCollection = new List<int>(),
				RecordsMissingInSecondaryCollection = new List<int>()
			};
			var actualResults = TestCollectionData.ORDER_OF_NUMBERS_1_THRU_10.Compare(TestCollectionData.ORDER_OF_NUMBERS_1_THRU_10);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSourceCollection, actualResults.RecordsMissingInSourceCollection);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSecondaryCollection, actualResults.RecordsMissingInSecondaryCollection);
		}

		[TestMethod]
		public void Collection_Function_Compare_TwoCollections_SecondCollectionMissing_Six_Thru_Ten_Valid()
		{
			var expectedResults = new CollectionCompareResults<int>
			{
				RecordsMissingInSourceCollection = new List<int>(),
				RecordsMissingInSecondaryCollection = TestCollectionData.ORDER_OF_NUMBERS_6_THRU_10
			};
			var actualResults = TestCollectionData.ORDER_OF_NUMBERS_1_THRU_10.Compare(TestCollectionData.ORDER_OF_NUMBERS_1_THRU_5);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSourceCollection, actualResults.RecordsMissingInSourceCollection);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSecondaryCollection, actualResults.RecordsMissingInSecondaryCollection);
		}

		[TestMethod]
		public void Collection_Function_Compare_TwoCollections_FirstCollectionMissing_Six_Thru_Ten_Valid()
		{
			var expectedResults = new CollectionCompareResults<int>
			{
				RecordsMissingInSourceCollection = TestCollectionData.ORDER_OF_NUMBERS_6_THRU_10,
				RecordsMissingInSecondaryCollection = new List<int>()
			};
			var actualResults = TestCollectionData.ORDER_OF_NUMBERS_1_THRU_5.Compare(TestCollectionData.ORDER_OF_NUMBERS_1_THRU_10);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSourceCollection, actualResults.RecordsMissingInSourceCollection);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSecondaryCollection, actualResults.RecordsMissingInSecondaryCollection);
		}

		[TestMethod]
		public void Collection_Function_Compare_TwoCollections_FirstCollectionMissing_Six_Thru_Ten_SecondCollectionMissing_One_Thru_Five_Valid()
		{
			var expectedResults = new CollectionCompareResults<int>
			{
				RecordsMissingInSourceCollection = TestCollectionData.ORDER_OF_NUMBERS_6_THRU_10,
				RecordsMissingInSecondaryCollection = TestCollectionData.ORDER_OF_NUMBERS_1_THRU_5
			};
			var actualResults = TestCollectionData.ORDER_OF_NUMBERS_1_THRU_5.Compare(TestCollectionData.ORDER_OF_NUMBERS_6_THRU_10);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSourceCollection, actualResults.RecordsMissingInSourceCollection);
			CollectionAssert.AreEqual(expectedResults.RecordsMissingInSecondaryCollection, actualResults.RecordsMissingInSecondaryCollection);
		}
	}
}
