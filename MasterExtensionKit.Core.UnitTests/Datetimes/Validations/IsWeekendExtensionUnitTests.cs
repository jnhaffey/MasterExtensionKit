using System;
using MasterExtensionKit.Core.Datetimes.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Datetimes.Validations
{
	[TestClass]
	public class IsValidationExtensionsUnitTests
	{
		#region IsWeekend Tests

		private DateTime _baseDate = new DateTime(2015, 11, 1);

		[TestMethod]
		public void IsWeekend_Sunday_True()
		{
			Assert.IsTrue(_baseDate.IsWeekend());
		}

		[TestMethod]
		public void IsWeekend_Monday_False()
		{
			Assert.IsFalse(_baseDate.AddDays(1).IsWeekend());
		}

		[TestMethod]
		public void IsWeekend_Tuesday_False()
		{
			Assert.IsFalse(_baseDate.AddDays(2).IsWeekend());
		}

		[TestMethod]
		public void IsWeekend_Wednesday_False()
		{
			Assert.IsFalse(_baseDate.AddDays(3).IsWeekend());
		}

		[TestMethod]
		public void IsWeekend_Thursday_False()
		{
			Assert.IsFalse(_baseDate.AddDays(4).IsWeekend());
		}

		[TestMethod]
		public void IsWeekend_Friday_False()
		{
			Assert.IsFalse(_baseDate.AddDays(5).IsWeekend());
		}

		[TestMethod]
		public void IsWeekend_Saturday_True()
		{
			Assert.IsTrue(_baseDate.AddDays(6).IsWeekend());
		}

		#endregion
	}
}