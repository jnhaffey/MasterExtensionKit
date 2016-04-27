using System;
using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Configuration;

namespace MasterExtensionKit.Core.Strings.Validations
{
	public static class IsGuidExtension
	{
		/// <summary>
		///     Checks if the given string is a valid Guid
		/// </summary>
		/// <param name="source"></param>
		/// <returns>Boolean</returns>
		public static bool IsGuid(this string source)
		{
			if (!source.HasValue())
				throw new ArgumentNullException(source);

			var format = new Regex(RegExpressions.GUID_REG_EXPRESSION);
			var match = format.Match(source);

			return match.Success;
		}

		//TODO:BETTER METHOD
		//public static bool IsValidGUid(this string source)
		//{
		//	Guid value;
		//	return Guid.TryParse(source, out value);
		//}
	}
}