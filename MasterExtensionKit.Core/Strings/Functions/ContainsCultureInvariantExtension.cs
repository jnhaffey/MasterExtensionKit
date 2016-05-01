using System.Globalization;
using MasterExtensionKit.Core.Strings.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class ContainsCultureInvariantExtension
	{
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