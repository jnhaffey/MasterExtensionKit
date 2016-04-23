using MasterExtensionKit.Strings.Checks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Strings.UnitTests.Checks
{
	[TestClass]
	public class IsValidPostalZipCodeUnitTest
	{
		#region US Postal Code Tests

		private const string UNITED_STATES_FORMAT5_VALID = "12345";
		private const string UNITED_STATES_FORMAT5_INVALID = "1234A";
		private const string UNITED_STATES_FORMAT10_1_VALID = "12345 1234";
		private const string UNITED_STATES_FORMAT10_1_INVALID1 = "123451234";
		private const string UNITED_STATES_FORMAT10_1_INVALID2 = "12345  1234";
		private const string UNITED_STATES_FORMAT10_2_VALID = "12345-1234";
		private const string UNITED_STATES_FORMAT10_2_INVALID = "12345_1234";

		[TestMethod]
		public void UnitedState_PostalCode_Format5_True()
		{
			Assert.IsTrue(UNITED_STATES_FORMAT5_VALID.IsValidPostalCode(Country.UnitedStates));
		}

		[TestMethod]
		public void UnitedState_PostalCode_Format5_False()
		{
			Assert.IsFalse(UNITED_STATES_FORMAT5_INVALID.IsValidPostalCode(Country.UnitedStates));
		}

		[TestMethod]
		public void UnitedState_PostalCode_Format10_1_True()
		{
			Assert.IsTrue(UNITED_STATES_FORMAT10_1_VALID.IsValidPostalCode(Country.UnitedStates));
		}

		[TestMethod]
		public void UnitedState_PostalCode_Format10_1_False()
		{
			Assert.IsFalse(UNITED_STATES_FORMAT10_2_INVALID.IsValidPostalCode(Country.UnitedStates));
		}

		[TestMethod]
		public void UnitedState_PostalCode_Format10_2_True()
		{
			Assert.IsTrue(UNITED_STATES_FORMAT10_2_VALID.IsValidPostalCode(Country.UnitedStates));
		}

		[TestMethod]
		public void UnitedState_PostalCode_Format10_2_1_False()
		{
			Assert.IsFalse(UNITED_STATES_FORMAT10_1_INVALID1.IsValidPostalCode(Country.UnitedStates));
		}

		[TestMethod]
		public void UnitedState_PostalCode_Format10_2_2_False()
		{
			Assert.IsFalse(UNITED_STATES_FORMAT10_1_INVALID2.IsValidPostalCode(Country.UnitedStates));
		}

		#endregion

		#region UK PostalCode Tests
		private const string UNITED_KINGDOM_1 = "SW1A 2JY";
		private const string UNITED_KINGDOM_2 = "SW1A2JY";

		[TestMethod]
		public void UnitedKingdom_Format1_True()
		{
			Assert.IsTrue(UNITED_KINGDOM_1.IsValidPostalCode(Country.UnitedKingdom));
		}

		[TestMethod]
		public void UnitedKingdom_Format2_False()
		{
			Assert.IsFalse(UNITED_KINGDOM_2.IsValidPostalCode(Country.UnitedKingdom));
		}
		#endregion
	}
}