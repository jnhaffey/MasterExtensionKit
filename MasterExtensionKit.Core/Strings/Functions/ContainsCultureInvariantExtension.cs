using System.Globalization;
using MasterExtensionKit.Core.Strings.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class ContainsCultureInvariantExtension
	{
		/// <summary>
		///     Evaluates if the given string is contained in the source string while ignoring culture
		/// </summary>
		/// <param name="source">The string source</param>
		/// <param name="contains">The string to compare with</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool ContainsCultureInvariant(this string source, string contains)
		{
			if (source.HasValue() && contains.HasValue())
			{
				return CultureInfo.InvariantCulture.CompareInfo.IndexOf(source, contains, CompareOptions.IgnoreCase) >= 0;
			}

			return false;
		}
	}
}