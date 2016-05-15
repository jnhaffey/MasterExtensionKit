using System;
using System.Collections.Generic;
using System.Linq;
using MasterExtensionKit.Core.Collections.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Collections.Functions
{
	[TestClass]
	public class RangeExtensionUnitTests
	{
		private readonly List<int> _expectedResult = new List<int> {3, 4, 5};

		[TestMethod]
		public void Collection_Function_Range_Count_Valid()
		{
			var actualResult = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN.Range(3, 5);
			Assert.AreEqual(_expectedResult.Count, actualResult.Count());
		}

		[TestMethod]
		public void Collection_Function_Range_Matching_Valid()
		{
			var actualResult = TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN.Range(3, 5);
			Assert.IsTrue(actualResult.SequenceEqual(_expectedResult));
		}

		[TestMethod]
		[ExpectedException(typeof(IndexOutOfRangeException), "StartIndex cannot be less than zero (0)")]
		public void Collection_Function_Range_StartIndex_OutOfRangeException()
		{
			TestCollectionData.ORDER_OF_NUMBERS_ONE_THRU_TEN.Range(-1, 5);
		}
	}
}