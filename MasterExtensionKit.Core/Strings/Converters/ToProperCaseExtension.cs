using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;
using MasterExtensionKit.Core.Strings.Validations;

namespace MasterExtensionKit.Core.Strings.Converters
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class ToProperCaseExtension
	{
		/// <summary>
		///     Converts the given string to Proper Case Style
		/// </summary>
		/// <param name="source">The string source</param>
		/// <returns>The modified string</returns>
		public static string ToProperCase(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (!source.HasValue())
			{
				throw new SourceEmptyException(nameof(source));
			}

			const string RegExpression = @"(?<!^)((?<!\d)\d|(?(?<=[A-Z])[A-Z](?=[a-z])|[A-Z]))";
			var result = Regex.Replace(source, RegExpression, " $1").ToLower();
			result = result.Substring(0, 1).ToUpper() + result.Substring(1);
			if (!result.Contains("."))
			{
				return result;
			}

			for (var index = 0; index < result.Length; index++)
			{
				if (result.Length == index + 1 || !result[index].Equals('.') || !result[index + 1].Equals(' '))
				{
					continue;
				}

				var nextLetterToUpper = index + 2;
				result = result.Substring(0, nextLetterToUpper) + result.Substring(nextLetterToUpper, 1).ToUpper() +
				         result.Substring(nextLetterToUpper + 1);
				index = nextLetterToUpper + 1;
			}

			return result;
		}
	}
}