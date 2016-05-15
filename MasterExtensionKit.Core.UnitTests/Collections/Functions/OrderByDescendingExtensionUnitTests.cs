using System.Linq;
using MasterExtensionKit.Core.Collections.Functions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Collections.Functions
{
	[TestClass]
	public class OrderByDescendingExtensionUnitTests
	{
		[TestMethod]
		public void Collection_Function_OrderByDescending_FirstName_NotSame_Valid()
		{
			var actualResult = TestCollectionData.LIST_OF_CUSTOMERS.OrderByDescending("FirstName");
			CollectionAssert.AreNotEqual(TestCollectionData.LIST_OF_CUSTOMERS, actualResult.ToList());
		}

		[TestMethod]
		public void Collection_Function_OrderByDescending_AccountBalance_Same_Valid()
		{
			var actualResult = TestCollectionData.LIST_OF_CUSTOMERS.OrderByDescending("AccountBalance");
			CollectionAssert.AreNotEqual(TestCollectionData.LIST_OF_CUSTOMERS, actualResult.ToList());
		}

		[TestMethod]
		[ExpectedException(typeof(PropertyNotFoundException), "Unable to find property 'Address' in type 'Customer'")]
		public void Collection_Function_OrderByDescending_Address_PropertyNotFoundException()
		{
			TestCollectionData.LIST_OF_CUSTOMERS.OrderByDescending("Address");
		}
	}
}