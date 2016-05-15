using System.Collections.Generic;

namespace MasterExtensionKit.Core.UnitTests._Shared
{
	public static class TestCollectionData
	{
		public static List<int> NULL_LIST = null;
		public static List<int> EMPTY_LIST = new List<int>();

		public static readonly List<Customer> LIST_OF_CUSTOMERS = new List<Customer>
		{
			new Customer {FirstName = "Jason", AccountBalance = 12039.23M},
			new Customer {FirstName = "Katherine", AccountBalance = 90875.33M},
			new Customer {FirstName = "Allyson", AccountBalance = 256.01M},
			new Customer {FirstName = "Ella", AccountBalance = 25.99M},
			new Customer {FirstName = "Bethany", AccountBalance = 10.00M},
			new Customer {FirstName = "Isabelle", AccountBalance = 38.47M},
			new Customer {FirstName = "Fred", AccountBalance = 0.00M}
		};

		public static readonly List<int> ORDER_OF_NUMBERS_ONE_THRU_FIVE = new List<int> {1, 2, 3, 4, 5};
		public static readonly List<int> ORDER_OF_NUMBERS_SIX_THRU_TEN = new List<int> {6, 7, 8, 9, 10};
		public static readonly List<int> ORDER_OF_NUMBERS_ONE_THRU_TEN = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
		public static readonly List<int> ORDER_OF_NUMBERS_TEN_THRU_ONE = new List<int> {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
	}

	public class Customer
	{
		public string FirstName { get; set; }
		public decimal AccountBalance { get; set; }
	}
}