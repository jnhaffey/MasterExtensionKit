using System;
using MasterExtensionKit.Core.Strings.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class EqualsCultureInveriantExtension
	{
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