using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace MasterExtensionKit.Strings.Converters
{
	public static class ToTextStylesExtensions
	{
		/// <summary>
		///     Converts the given string to Pascal Case Style
		/// </summary>
		/// <param name="value"></param>
		/// <returns>String</returns>
		public static string ToPascalCase(this string value)
		{
			var info = Thread.CurrentThread.CurrentCulture.TextInfo;
			value = info.ToTitleCase(value);
			var parts = value.Split(new char[] {}, StringSplitOptions.RemoveEmptyEntries);
			var result = string.Join(string.Empty, parts);
			return result;
		}

		/// <summary>
		///     Converts the given string to Camel Case Style
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string ToCamelCase(this string value)
		{
			value = value.ToProperCase().ToPascalCase();
			return value.Substring(0, 1).ToLower() + value.Substring(1);
		}

		/// <summary>
		///     Converts the given string to Proper Case Style
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string ToProperCase(this string value)
		{
			const string regExpression = @"(?<!^)((?<!\d)\d|(?(?<=[A-Z])[A-Z](?=[a-z])|[A-Z]))";
			var result = Regex.Replace(value, regExpression, " $1").ToLower();
			result = result.Substring(0, 1).ToUpper() + result.Substring(1);
			if (!result.Contains(".")) return result;
			for (var index = 0; index < result.Length; index++)
			{
				if (result.Length == index+1 || !result[index].Equals('.') || !result[index + 1].Equals(' ')) continue;
				var nextLetterToUpper = index + 2;
				result = result.Substring(0, nextLetterToUpper) + result.Substring(nextLetterToUpper, 1).ToUpper() +
				         result.Substring(nextLetterToUpper + 1);
				index = nextLetterToUpper + 1;
			}
			return result;
		}
	}
}