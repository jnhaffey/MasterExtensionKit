using System.Linq;
using MasterExtensionKit.Core.Collections.Functions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Collections.Functions
{
	[TestClass]
	public class WhereIfEnumerableExtensionsTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Collection_Function_WhereIf_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Collection_Function_WhereIf_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion

		[TestMethod]
		public void Collection_Function_WhereIf_Include_AccountBalanceUnder100_And_NameContainsLetterA()
		{
			var onlyAccountsLessThan100 = true;
			var expectedCount = 3;
			var actualResult = TestCollectionData.LIST_OF_CUSTOMERS
				.WhereIf(onlyAccountsLessThan100, c => c.AccountBalance < 100)
				.Where(c => c.FirstName.Contains('a'))
				.ToList();
			Assert.AreEqual(expectedCount, actualResult.Count());
		}

		[TestMethod]
		public void Collection_Function_WhereIf_Ignore_AccountBalanceUnder100_And_NameContainsLetterA()
		{
			var onlyAccountsLessThan100 = false;
			var expectedCount = 5;
			var actualResult = TestCollectionData.LIST_OF_CUSTOMERS
				.WhereIf(onlyAccountsLessThan100, c => c.AccountBalance < 100)
				.Where(c => c.FirstName.Contains('a'))
				.ToList();
			Assert.AreEqual(expectedCount, actualResult.Count());
		}
	}
}