using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class RemoveNonAlphaNumericExtension
	{
		public static string RemoveNonAlphaNumeric(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var regExpression = new Regex("[^a-zA-Z0-9 -]");
			return regExpression.Replace(source, "");
		}
	}
}