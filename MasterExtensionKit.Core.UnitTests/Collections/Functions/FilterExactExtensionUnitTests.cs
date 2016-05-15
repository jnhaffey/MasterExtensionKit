using System;
using System.Collections.Generic;
using System.Linq;
using MasterExtensionKit.Core.Collections.Functions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Collections.Functions
{
	[TestClass]
	public class FilterExactExtensionUnitTests
	{
		[TestMethod]
		public void Collection_Function_FilterExact_FirstName_NotFound_Valid()
		{
			var expectedResults = new List<Customer>();
			var actualResult = TestCollectionData.LIST_OF_CUSTOMERS.FilterExact("FirstName", "Robert").ToList();
			CollectionAssert.AreEqual(expectedResults, actualResult);
		}

		[TestMethod]
		public void Collection_Function_FilterExact_FirstName_Same_Valid()
		{
			var expectedResult = TestCollectionData.LIST_OF_CUSTOMERS.Where(c => c.FirstName.Equals("Jason")).ToList();
			var actualResult = TestCollectionData.LIST_OF_CUSTOMERS.FilterExact("FirstName","Jason").ToList();
			CollectionAssert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod]
		[ExpectedException(typeof(PropertyNotFoundException), "Unable to find property 'Address' in type 'Customer'")]
		public void Collection_Function_FilterExact_Address_PropertyNotFoundException()
		{
			TestCollectionData.LIST_OF_CUSTOMERS.FilterExact("Address","123 High Stret");
		}
	}
}
