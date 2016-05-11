using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class RemoveAlphaExtension
	{
		public static string RemoveAlpha(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var regExpression = new Regex("[a-zA-Z]");
			return regExpression.Replace(source, "");
		}
	}
}