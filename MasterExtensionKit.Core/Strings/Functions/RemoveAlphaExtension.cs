using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class RemoveAlphaExtension
	{
		/// <summary>
		///     Will remove all alpha characters from within the given string
		/// </summary>
		/// <param name="source">The string source</param>
		/// <returns>The modified string</returns>
		public static string RemoveAlpha(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var regExpression = new Regex("[a-zA-Z]");
			return regExpression.Replace(source, string.Empty);
		}
	}
}