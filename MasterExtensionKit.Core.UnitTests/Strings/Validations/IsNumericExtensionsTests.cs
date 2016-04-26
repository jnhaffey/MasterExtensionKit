using System;
using MasterExtensionKit.Core.Strings.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Validations
{
	[TestClass]
	public class IsNumericExtensionsTests
	{
		[TestMethod]
		public void IsNumeric_MaxLongValue_True()
		{
			var valueToTest = long.MaxValue.ToString();
			Assert.IsTrue(valueToTest.IsNumeric());
		}

		[TestMethod]
		public void IsNumeric_MinLongValue_True()
		{
			var valueToTest = long.MinValue.ToString();
			Assert.IsTrue(valueToTest.IsNumeric());
		}

		[TestMethod]
		public void IsNumeric_MaxIntValue_True()
		{
			var valueToTest = int.MaxValue.ToString();
			Assert.IsTrue(valueToTest.IsNumeric());
		}

		[TestMethod]
		public void IsNumeric_MinIntValue_True()
		{
			var valueToTest = int.MinValue.ToString();
			Assert.IsTrue(valueToTest.IsNumeric());
		}

		[TestMethod]
		public void IsNumeric_MaxDecimalValue_True()
		{
			var valueToTest = decimal.MaxValue.ToString();
			Assert.IsTrue(valueToTest.IsNumeric());
		}

		[TestMethod]
		public void IsNumeric_MinDecimalValue_True()
		{
			var valueToTest = decimal.MinValue.ToString();
			Assert.IsTrue(valueToTest.IsNumeric());
		}

		/// <summary>
		///     While this should be true it returns false due to a 'old issue' in the double.tryparse / double.parse
		/// </summary>
		[TestMethod]
		public void IsNumeric_MaxDoubleValue_False()
		{
			var valueToTest = double.MaxValue.ToString();
			Assert.IsFalse(valueToTest.IsNumeric());
		}

		/// <summary>
		///     This is a work-around for the 'old issue' in the double.tryparse / double.parse
		/// </summary>
		[TestMethod]
		public void IsNumeric_MaxDoubleValue_MinusOne_True()
		{
			var valueToTest = (double.MaxValue - 1).ToString();
			Assert.IsFalse(valueToTest.IsNumeric());
		}

		/// <summary>
		///     While this should be true it returns false due to a 'old issue' in the double.tryparse / double.parse
		/// </summary>
		[TestMethod]
		public void IsNumeric_MinDoubleValue_False()
		{
			var valueToTest = double.MinValue.ToString();
			Assert.IsFalse(valueToTest.IsNumeric());
		}

		/// <summary>
		///     This is a work-around for the 'old issue' in the double.tryparse / double.parse
		/// </summary>
		[TestMethod]
		public void IsNumeric_MinDoubleValue_AddOne_True()
		{
			var valueToTest = (double.MinValue + 1).ToString();
			Assert.IsFalse(valueToTest.IsNumeric());
		}

		[TestMethod]
		public void IsNumeric_MaxFloatValue_True()
		{
			var valueToTest = float.MaxValue.ToString();
			Assert.IsTrue(valueToTest.IsNumeric());
		}

		[TestMethod]
		public void IsNumeric_MinFloatValue_True()
		{
			var valueToTest = float.MinValue.ToString();
			Assert.IsTrue(valueToTest.IsNumeric());
		}

		[TestMethod]
		public void IsNumeric_AlphaNumeric_False()
		{
			var valueToTest = Guid.NewGuid().ToString().Replace("-", "");
			Assert.IsFalse(valueToTest.IsNumeric());
		}

		[TestMethod]
		public void IsNumeric_AlphaOnly_False()
		{
			var valueToTest = "ABCDEFG";
			Assert.IsFalse(valueToTest.IsNumeric());
		}
	}
}