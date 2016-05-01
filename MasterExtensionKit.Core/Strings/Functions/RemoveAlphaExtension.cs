using System.Text.RegularExpressions;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class RemoveAlphaExtension
	{
		public static string RemoveAlpha(this string source)
		{
			var regExpression = new Regex("[a-zA-Z]");
			return regExpression.Replace(source, "");
		}
	}
}