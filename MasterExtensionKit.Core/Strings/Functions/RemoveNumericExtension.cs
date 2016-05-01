using System.Text.RegularExpressions;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class RemoveNumericExtension
	{
		public static string RemoveNumeric(this string source)
		{
			var regExpression = new Regex("[0-9]");
			return regExpression.Replace(source, "");
		}
	}
}