using System.Text.RegularExpressions;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class RemoveNonAlphaNumericExtension
	{
		public static string RemoveNonAlphaNumeric(this string source)
		{
			var regExpression = new Regex("[^a-zA-Z0-9 -]");
			return regExpression.Replace(source, "");
		}
	}
}