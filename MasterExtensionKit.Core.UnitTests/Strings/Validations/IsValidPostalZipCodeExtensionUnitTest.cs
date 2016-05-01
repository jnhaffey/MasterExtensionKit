using MasterExtensionKit.Core.Enumerations;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Strings.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Validations
{
	[TestClass]
	public class IsValidPostalZipCodeExtensionUnitTest
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof (SourceNullException), "")]
		public void String_Validation_IsValidPostalCode_Null_Exception()
		{
			TestStringData.NULL_STRING.IsValidPostalCode(Country.UNITED_KINGDOM);
		}

		[TestMethod]
		public void String_Validation_IsValidPostalCode_Empty_Invalid()
		{
			Assert.IsFalse(TestStringData.EMPTY_STRING.IsValidPostalCode(Country.UNITED_KINGDOM));
		}

		#endregion

		#region US Postal Code Tests

		[TestMethod]
		public void String_Validation_IsValidPostalCode_UnitedState_PostalCode_Format5_Valid()
		{
			Assert.IsTrue(TestStringData.UNITED_STATES_FIVE_CHAR_FORMAT_VALID.IsValidPostalCode(Country.UNITED_STATES));
		}

		[TestMethod]
		public void String_Validation_IsValidPostalCode_UnitedState_PostalCode_Format5_Invalid()
		{
			Assert.IsFalse(TestStringData.UNITED_STATES_FIVE_CHAR_FORMAT_INVALID.IsValidPostalCode(Country.UNITED_STATES));
		}

		[TestMethod]
		public void String_Validation_IsValidPostalCode_UnitedState_PostalCode_Format10_1_Valid()
		{
			Assert.IsTrue(TestStringData.UNITED_STATES_TEN_CHAR_FORMAT_STYLE_ONE_VALID.IsValidPostalCode(Country.UNITED_STATES));
		}

		[TestMethod]
		public void String_Validation_IsValidPostalCode_UnitedState_PostalCode_Format10_1_Invalid()
		{
			Assert.IsFalse(
				TestStringData.UNITED_STATES_TEN_CHAR_FORMAT_STYLE_INVALID_THREE.IsValidPostalCode(Country.UNITED_STATES));
		}

		[TestMethod]
		public void String_Validation_IsValidPostalCode_UnitedState_PostalCode_Format10_2_Valid()
		{
			Assert.IsTrue(TestStringData.UNITED_STATES_TEN_CHAR_FORMAT_STYLE_TWO_VALID.IsValidPostalCode(Country.UNITED_STATES));
		}

		[TestMethod]
		public void String_Validation_IsValidPostalCode_UnitedState_PostalCode_Format10_2_1_Invalid()
		{
			Assert.IsFalse(TestStringData.UNITED_STATES_TEN_CHAR_FORMAT_STYLE_INVALID_ONE.IsValidPostalCode(Country.UNITED_STATES));
		}

		[TestMethod]
		public void String_Validation_IsValidPostalCode_UnitedState_PostalCode_Format10_2_2_Invalid()
		{
			Assert.IsFalse(TestStringData.UNITED_STATES_TEN_CHAR_FORMAT_SYTLE_INVALID_TWO.IsValidPostalCode(Country.UNITED_STATES));
		}

		#endregion

		#region UK PostalCode Tests

		[TestMethod]
		public void String_Validation_IsValidPostalCode_UnitedKingdom_Format1_Valid()
		{
			Assert.IsTrue(TestStringData.UNITED_KINGDOM_FORMAT_ONE_VALID.IsValidPostalCode(Country.UNITED_KINGDOM));
		}

		[TestMethod]
		public void String_Validation_IsValidPostalCode_UnitedKingdom_Format2_Invalid()
		{
			Assert.IsFalse(TestStringData.UNITED_KINGDOM_FORMAT_TWO_VALID.IsValidPostalCode(Country.UNITED_KINGDOM));
		}

		#endregion
	}
}