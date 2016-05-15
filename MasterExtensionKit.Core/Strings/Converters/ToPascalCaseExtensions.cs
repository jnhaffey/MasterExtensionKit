using System;
using System.Threading;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;
using MasterExtensionKit.Core.Strings.Functions;

namespace MasterExtensionKit.Core.Strings.Converters
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class ToPascalCaseExtensions
	{
		/// <summary>
		///     Converts the given string to Pascal Case Style
		/// </summary>
		/// <param name="source">The source string</param>
		/// <returns>The modified string</returns>
		public static string ToPascalCase(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var cleanSource = source.RemoveNonAlphaNumeric();

			var info = Thread.CurrentThread.CurrentCulture.TextInfo;
			var temp = info.ToTitleCase(cleanSource);
			var parts = temp.Split(new char[] {}, StringSplitOptions.RemoveEmptyEntries);
			var result = string.Join(string.Empty, parts);
			return result;
		}
	}
}