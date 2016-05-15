using System;
using MasterExtensionKit.Core.Strings.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class EqualsCultureInveriantExtension
	{
		/// <summary>
		///     Evaluates if two string are equal while ignoring culture
		/// </summary>
		/// <param name="source">The string source</param>
		/// <param name="equals">The string to compare with</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool EqualsCultureInveriant(this string source, string equals)
		{
			if (source.HasValue() && equals.HasValue())
			{
				return source.Equals(equals, StringComparison.InvariantCultureIgnoreCase);
			}

			return false;
		}
	}
}