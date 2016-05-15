using System;
using System.Linq;
using MasterExtensionKit.Core.Collections.Functions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Collections.Functions
{
	[TestClass]
	public class OrderByAscendingExtensionUnitTests
	{
		[TestMethod]
		public void Collection_Function_OrderByAscending_FirstName_NotSame_Valid()
		{
			var actualResult = TestCollectionData.LIST_OF_CUSTOMERS.OrderByAscending("FirstName");
			CollectionAssert.AreNotEqual(TestCollectionData.LIST_OF_CUSTOMERS, actualResult.ToList());
		}

		[TestMethod]
		public void Collection_Function_OrderByAscending_AccountBalance_Same_Valid()
		{
			var expectedResult = TestCollectionData.LIST_OF_CUSTOMERS;
			expectedResult.Reverse();
			var actualResult = TestCollectionData.LIST_OF_CUSTOMERS.OrderByAscending("AccountBalance");
			CollectionAssert.AreNotEqual(expectedResult, actualResult.ToList());
		}

		[TestMethod]
		[ExpectedException(typeof(PropertyNotFoundException), "Unable to find property 'Address' in type 'Customer'")]
		public void Collection_Function_OrderByAscending_Address_PropertyNotFoundException()
		{
			TestCollectionData.LIST_OF_CUSTOMERS.OrderByAscending("Address");
		}
	}
}
