namespace MasterExtensionKit.Core.Strings.Validations
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class HasValueExtension
	{
		/// <summary>
		///     Will validate if a string has any value
		/// </summary>
		/// <param name="source">The string source</param>
		/// ///
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool HasValue(this string source)
		{
			return !string.IsNullOrWhiteSpace(source);
		}
	}
}