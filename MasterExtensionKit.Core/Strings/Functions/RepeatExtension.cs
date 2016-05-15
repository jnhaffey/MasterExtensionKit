using System;
using System.Text;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class RepeatExtension
	{
		/// <summary>
		///     Will repeat the given string the given count times
		/// </summary>
		/// <param name="source">The string source</param>
		/// <param name="count">The number of times to repeat</param>
		/// <returns>The modified string</returns>
		public static string Repeat(this string source, int count)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (count.IsNull())
			{
				throw new ArgumentNullException(nameof(count));
			}

			if (count <= 0)
			{
				throw new UnknownOrUnsupportedOptionException(
					ErrorMessages.UnsupportedNumericValueError(nameof(count), count.ToString()));
			}

			var stringBuilder = new StringBuilder();

			for (var i = 0; i < count; i++)
			{
				stringBuilder.Append(source);
			}

			return stringBuilder.ToString();
		}
	}
}