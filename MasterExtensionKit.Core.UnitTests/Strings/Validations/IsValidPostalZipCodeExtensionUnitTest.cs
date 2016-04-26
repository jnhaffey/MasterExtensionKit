using MasterExtensionKit.Core.Enumerations;
using MasterExtensionKit.Core.Strings.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Validations
{
	[TestClass]
	public class IsValidPostalZipCodeExtensionUnitTest
	{
		#region US Postal Code Tests

		[TestMethod]
		public void UnitedState_PostalCode_Format5_True()
		{
			Assert.IsTrue(TestStringData.UNITED_STATES_FORMAT5_VALID.IsValidPostalCode(Country.UnitedStates));
		}

		[TestMethod]
		public void UnitedState_PostalCode_Format5_False()
		{
			Assert.IsFalse(TestStringData.UNITED_STATES_FORMAT5_INVALID.IsValidPostalCode(Country.UnitedStates));
		}

		[TestMethod]
		public void UnitedState_PostalCode_Format10_1_True()
		{
			Assert.IsTrue(TestStringData.UNITED_STATES_FORMAT10_1_VALID.IsValidPostalCode(Country.UnitedStates));
		}

		[TestMethod]
		public void UnitedState_PostalCode_Format10_1_False()
		{
			Assert.IsFalse(TestStringData.UNITED_STATES_FORMAT10_2_INVALID.IsValidPostalCode(Country.UnitedStates));
		}

		[TestMethod]
		public void UnitedState_PostalCode_Format10_2_True()
		{
			Assert.IsTrue(TestStringData.UNITED_STATES_FORMAT10_2_VALID.IsValidPostalCode(Country.UnitedStates));
		}

		[TestMethod]
		public void UnitedState_PostalCode_Format10_2_1_False()
		{
			Assert.IsFalse(TestStringData.UNITED_STATES_FORMAT10_1_INVALID1.IsValidPostalCode(Country.UnitedStates));
		}

		[TestMethod]
		public void UnitedState_PostalCode_Format10_2_2_False()
		{
			Assert.IsFalse(TestStringData.UNITED_STATES_FORMAT10_1_INVALID2.IsValidPostalCode(Country.UnitedStates));
		}

		#endregion

		#region UK PostalCode Tests

		[TestMethod]
		public void UnitedKingdom_Format1_True()
		{
			Assert.IsTrue(TestStringData.UNITED_KINGDOM_1.IsValidPostalCode(Country.UnitedKingdom));
		}

		[TestMethod]
		public void UnitedKingdom_Format2_False()
		{
			Assert.IsFalse(TestStringData.UNITED_KINGDOM_2.IsValidPostalCode(Country.UnitedKingdom));
		}

		#endregion
	}
}