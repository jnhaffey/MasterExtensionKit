using System.Globalization;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class ContainsCultureInvariantExtension
	{
		public static bool ContainsCultureInvariant(this string source, string contains)
		{
			if (string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(contains))
			{
				return false;
			}
			return CultureInfo.InvariantCulture.CompareInfo.IndexOf(source, contains, CompareOptions.IgnoreCase) >= 0;
		}
	}
}