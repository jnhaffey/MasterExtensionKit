using System;
using MasterExtensionKit.Core.Datetimes.Validations;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Datetimes.Validations
{
	[TestClass]
	public class IsWeekendExtensionUnitTests
	{
		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Datetime_Validation_IsWeekend_Null_Exception()
		{
			Assert.Fail();
		}

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void Datetime_Validation_IsWeekend_Empty_Invalid()
		{
			Assert.Fail();
		}

		#endregion

		#region IsWeekend Tests
		[TestMethod]
		public void Datetime_Validation_IsWeekend_Sunday_True()
		{
			Assert.IsTrue(TestDateTimeData.DATETIME_BASE_2015_1_1.IsWeekend());
		}

		[TestMethod]
		public void Datetime_Validation_IsWeekend_Monday_False()
		{
			Assert.IsFalse(TestDateTimeData.DATETIME_BASE_2015_1_1.AddDays(1).IsWeekend());
		}

		[TestMethod]
		public void Datetime_Validation_IsWeekend_Tuesday_False()
		{
			Assert.IsFalse(TestDateTimeData.DATETIME_BASE_2015_1_1.AddDays(2).IsWeekend());
		}

		[TestMethod]
		public void Datetime_Validation_IsWeekend_Wednesday_False()
		{
			Assert.IsFalse(TestDateTimeData.DATETIME_BASE_2015_1_1.AddDays(3).IsWeekend());
		}

		[TestMethod]
		public void Datetime_Validation_IsWeekend_Thursday_False()
		{
			Assert.IsFalse(TestDateTimeData.DATETIME_BASE_2015_1_1.AddDays(4).IsWeekend());
		}

		[TestMethod]
		public void Datetime_Validation_IsWeekend_Friday_False()
		{
			Assert.IsFalse(TestDateTimeData.DATETIME_BASE_2015_1_1.AddDays(5).IsWeekend());
		}

		[TestMethod]
		public void Datetime_Validation_IsWeekend_Saturday_True()
		{
			Assert.IsTrue(TestDateTimeData.DATETIME_BASE_2015_1_1.AddDays(6).IsWeekend());
		}

		#endregion
	}
}