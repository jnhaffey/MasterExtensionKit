using System.Globalization;

namespace MasterExtensionKit.Core.Configuration
{
	/// <summary>
	///     Static Data Store
	/// </summary>
	internal static class StaticDataStore
	{
		/// <summary>
		///     Provides the Double Maximum Value in String Format
		/// </summary>
		internal static readonly string MaxDoubleValue = double.MaxValue.ToString(CultureInfo.InvariantCulture);

		/// <summary>
		///     Provides the Double Minimum Value in String Format
		/// </summary>
		internal static readonly string MinDoubleValue = double.MinValue.ToString(CultureInfo.InvariantCulture);
	}
}