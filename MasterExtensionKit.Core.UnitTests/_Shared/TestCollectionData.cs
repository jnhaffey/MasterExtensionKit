using System.Collections.Generic;

namespace MasterExtensionKit.Core.UnitTests._Shared
{
	public static class TestCollectionData
	{
		public static readonly List<Customer> Customers = new List<Customer>
		{
			new Customer {FirstName = "Jason", AccountBalance = 12039.23M},
			new Customer {FirstName = "Katherine", AccountBalance = 90875.33M},
			new Customer {FirstName = "Allyson", AccountBalance = 256.01M},
			new Customer {FirstName = "Ella", AccountBalance = 25.99M},
			new Customer {FirstName = "Bethany", AccountBalance = 10.00M},
			new Customer {FirstName = "Isabelle", AccountBalance = 38.47M},
			new Customer {FirstName = "Fred", AccountBalance = 0.00M}
		};

		public static readonly List<int> OrderNumbers = new List<int> {1, 2, 3, 4, 5};
	}

	public class Customer
	{
		public string FirstName { get; set; }
		public decimal AccountBalance { get; set; }
	}
}