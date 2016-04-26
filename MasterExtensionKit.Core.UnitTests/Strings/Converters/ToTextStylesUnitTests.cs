using MasterExtensionKit.Core.Strings.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.Strings.Converters
{
	[TestClass]
	public class ToTextStylesUnitTests
	{
		private const string PROPER_TEXT = "I am a proper sentence. I am a proper sentence.";

		private const string PASCAL_TEXT = "IAmAProperSentence.IAmAProperSentence.";

		private const string CAMEL_TEXT = "iAmAProperSentence.IAmAProperSentence.";

		[TestMethod]
		public void ToPascalCase_Test()
		{
			var actualResults = PROPER_TEXT.ToPascalCase();
			Assert.AreEqual(PASCAL_TEXT, actualResults);
		}

		[TestMethod]
		public void ToCamelCase_Test()
		{
			var actualResults = PROPER_TEXT.ToCamelCase();
			Assert.AreEqual(CAMEL_TEXT, actualResults);
		}

		[TestMethod]
		public void ToProperCase_Test()
		{
			var actualResults = PASCAL_TEXT.ToProperCase();
			Assert.AreEqual(PROPER_TEXT, actualResults);
		}
	}
}