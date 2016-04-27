namespace MasterExtensionKit.Core.Numbers.Validations
{
	public static class IsEvenExtension
	{
		/// <summary>
		///     Checks if number is Even
		/// </summary>
		/// <param name="source"></param>
		/// <returns>Boolean</returns>
		public static bool IsEven(this int source)
		{
			return source%2 == 0;
		}
	}
}