namespace MasterExtensionKit.Strings.Validations
{
	public static class HasValueExtension
	{
		/// <summary>
		///     Checks if the string has any value
		/// </summary>
		/// <param name="source"></param>
		/// <returns>Boolean</returns>
		public static bool HasValue(this string source)
		{
			return !string.IsNullOrWhiteSpace(source);
		}
	}
}