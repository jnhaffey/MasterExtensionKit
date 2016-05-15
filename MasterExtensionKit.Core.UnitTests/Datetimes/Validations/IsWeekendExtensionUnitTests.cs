using MasterExtensionKit.Core.Datetimes.Validations;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Datetimes.Validations
{
	[TestClass]
	public class IsWeekendExtensionUnitTests
	{
		#region IsWeekend Tests

		[TestMethod]
		public void Datetime_Validation_IsWeekend_Thursday_Invalid()
		{
			Assert.IsFalse(TestDateTimeData.DATETIME_BASE_2015_1_1.IsWeekend());
		}

		[TestMethod]
		public void Datetime_Validation_IsWeekend_Friday_Invalid()
		{
			Assert.IsFalse(TestDateTimeData.DATETIME_BASE_2015_1_1.AddDays(1).IsWeekend());
		}

		[TestMethod]
		public void Datetime_Validation_IsWeekend_Saturday_Valid()
		{
			Assert.IsTrue(TestDateTimeData.DATETIME_BASE_2015_1_1.AddDays(2).IsWeekend());
		}

		[TestMethod]
		public void Datetime_Validation_IsWeekend_Sunday_Valid()
		{
			Assert.IsTrue(TestDateTimeData.DATETIME_BASE_2015_1_1.AddDays(3).IsWeekend());
		}

		[TestMethod]
		public void Datetime_Validation_IsWeekend_Monday_Invalid()
		{
			Assert.IsFalse(TestDateTimeData.DATETIME_BASE_2015_1_1.AddDays(4).IsWeekend());
		}

		[TestMethod]
		public void Datetime_Validation_IsWeekend_Tuesday_Invalid()
		{
			Assert.IsFalse(TestDateTimeData.DATETIME_BASE_2015_1_1.AddDays(5).IsWeekend());
		}

		[TestMethod]
		public void Datetime_Validation_IsWeekend_Wednesday_Invalid()
		{
			Assert.IsFalse(TestDateTimeData.DATETIME_BASE_2015_1_1.AddDays(6).IsWeekend());
		}

		#endregion
	}
}