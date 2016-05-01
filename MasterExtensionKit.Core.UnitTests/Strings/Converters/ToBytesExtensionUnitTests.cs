using System.Linq;
using MasterExtensionKit.Core.Strings.Converters;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Converters
{
	[TestClass]
	public class ToBytesExtensionUnitTests
	{
		[TestMethod]
		public void ToBytes_Matching_Length()
		{
			var expectedResults = TestByteData.DataToSaveBytes;
			var actualResults = TestStringData.STRING_PROPER_STYLE.ToBytes();
			Assert.AreEqual(expectedResults.Length, actualResults.Length);
		}

		[TestMethod]
		public void ToBytes_Matching_Value()
		{
			var expectedResults = TestByteData.DataToSaveBytes;
			var actualResults = TestStringData.STRING_PROPER_STYLE.ToBytes();
			var finalResult = !actualResults.Where((t, i) => t != expectedResults[i]).Any();
			Assert.IsTrue(finalResult);
		}
	}
}