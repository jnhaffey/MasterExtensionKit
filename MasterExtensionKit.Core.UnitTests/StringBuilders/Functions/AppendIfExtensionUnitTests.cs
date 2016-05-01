using System;
using System.Text;
using MasterExtensionKit.Core.StringBuilders.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.StringBuilders.Functions
{
	[TestClass]
	public class AppendIfExtensionUnitTests
	{
		[TestMethod]
		public void AppendIf_DoubleSameString()
		{
			const string expectedResults = TestStringData.STRING_PROPER_STYLE + TestStringData.STRING_PROPER_STYLE;
			var stringBuilder = new StringBuilder(TestStringData.STRING_PROPER_STYLE);
			stringBuilder.AppendIf(true, TestStringData.STRING_PROPER_STYLE);
			Assert.AreEqual(expectedResults, stringBuilder.ToString());
		}
	}
}
