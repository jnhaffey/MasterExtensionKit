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
	public class SearchExtensionUnitTests
	{
		[TestMethod]
		public void Collection_Function_Search_Count_Valid()
		{
			var expectedResult = TestCollectionData.LIST_OF_CUSTOMERS.Where(c => c.FirstName.Equals("Jason")).ToList();
			var actualResult = TestCollectionData.LIST_OF_CUSTOMERS.Search("Jason");
			Assert.AreEqual(expectedResult.Count(), actualResult.Count());
		}

		[TestMethod]
		public void Collection_Function_Search_Count_Invalid()
		{
			var expectedResult = new List<Customer>();
			var actualResult = TestCollectionData.LIST_OF_CUSTOMERS.Search("Dan");
			Assert.AreEqual(expectedResult.Count, actualResult.Count());
		}

		[TestMethod]
		public void Collection_Function_Search_InstanceType_Valid()
		{
			var actualResult = TestCollectionData.LIST_OF_CUSTOMERS.Search("Jason");
			Assert.IsInstanceOfType(actualResult, typeof(IEnumerable<Customer>));
		}

		[TestMethod]
		public void Collection_Function_Search_InstanceType_Invalid()
		{
			var actualResult = TestCollectionData.LIST_OF_CUSTOMERS.Search("Dan");
			Assert.IsInstanceOfType(actualResult, typeof(IEnumerable<Customer>));
		}
	}
}
