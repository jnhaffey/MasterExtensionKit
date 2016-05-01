using System.Globalization;

namespace MasterExtensionKit.Core.Configuration
{
	internal class StaticDataStore
	{
		internal static readonly string MAX_DOUBLE_VALUE = double.MaxValue.ToString(CultureInfo.InvariantCulture);
		internal static readonly string MIN_DOUBLE_VALUE = double.MinValue.ToString(CultureInfo.InvariantCulture);
	}
}