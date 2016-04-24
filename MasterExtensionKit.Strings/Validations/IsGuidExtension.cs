using System;
using System.Text.RegularExpressions;

namespace MasterExtensionKit.Strings.Validations
{
	public static class IsGuidExtension
	{
		private const string GUID_REG_EXPRESSION = @"^[{(]?[0-9A-Fa-f]{8}[-]?([0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}[)}]?$";

		/// <summary>
		/// Checks if the given string is a valid Guid
		/// </summary>
		/// <param name="source"></param>
		/// <returns>Boolean</returns>
		public static bool IsGuid(this string source)
		{
			if (!source.HasValue())
				throw new ArgumentNullException(source);

			var format = new Regex(GUID_REG_EXPRESSION);
			var match = format.Match(source);

			return match.Success;
		}
	}
}