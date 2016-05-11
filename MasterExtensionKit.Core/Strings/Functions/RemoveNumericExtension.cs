using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class RemoveNumericExtension
	{
		public static string RemoveNumeric(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var regExpression = new Regex("[0-9]");
			return regExpression.Replace(source, "");
		}
	}
}