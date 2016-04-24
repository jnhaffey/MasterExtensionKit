using System.Linq;
using MasterExtensionKit.Collections.Functions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Collections.UnitTests.Functions
{
	[TestClass()]
	public class WhereIfEnumerableExtensionsTests
	{
		[TestMethod()]
		public void WhereIf_Include_AccountBalanceUnder100_And_NameContainsLetterA()
		{
			var OnlyAccountsLessThan100 = true;
			var expectedCount = 3;
			var actualResult = TestData.Customers
										.WhereIf(OnlyAccountsLessThan100, c => c.AccountBalance < 100)
										.Where(c => c.FirstName.Contains('a'))
										.ToList();
			Assert.AreEqual(expectedCount, actualResult.Count());
		}

		[TestMethod()]
		public void WhereIf_Ignore_AccountBalanceUnder100_And_NameContainsLetterA()
		{
			var OnlyAccountsLessThan100 = false;
			var expectedCount = 5;
			var actualResult = TestData.Customers
										.WhereIf(OnlyAccountsLessThan100, c => c.AccountBalance < 100)
										.Where(c => c.FirstName.Contains('a'))
										.ToList();
			Assert.AreEqual(expectedCount, actualResult.Count());
		}
	}
}