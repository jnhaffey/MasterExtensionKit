using System;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class EqualsCultureInveriantExtension
	{
		public static bool EqualsCultureInveriant(this string source, string equals)
		{
			if (string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(equals))
			{
				return false;
			}
			return source.Equals(equals, StringComparison.InvariantCultureIgnoreCase);
		}
	}
}