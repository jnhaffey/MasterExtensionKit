using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;
using MasterExtensionKit.Core.Strings.Functions;

namespace MasterExtensionKit.Core.Strings.Converters
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class ToCamelCaseExtension
	{
		/// <summary>
		///     Converts the given string to Camel Case Style
		/// </summary>
		/// <param name="source">The string source</param>
		/// <returns>The modified string</returns>
		public static string ToCamelCase(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var cleanSource = source.RemoveNonAlphaNumeric();

			var temp = cleanSource.ToProperCase().ToPascalCase();
			var result = temp.Substring(0, 1).ToLower() + temp.Substring(1);
			return result;
		}
	}
}