using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class GetWordCountExtension
	{
		/// <summary>
		///     Gets the word count for the given string
		/// </summary>
		/// <param name="source">The string source</param>
		/// <returns>Count of words</returns>
		public static int GetWordCount(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var count = 0;
			try
			{
				var regex = new Regex(RegExpressions.WHITE_SPACE);
				var matches = regex.Matches(source);
				count = matches.Count;
			}
			catch
			{
				// TODO: Make better Exception Handling
				throw;
			}

			return count;
		}
	}
}