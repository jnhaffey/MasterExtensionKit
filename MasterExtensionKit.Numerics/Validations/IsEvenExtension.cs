namespace MasterExtensionKit.Numerics.Validations
{
	public static class IsEvenExtension
	{
		/// <summary>
		///     Checks if number is Even
		/// </summary>
		/// <param name="value"></param>
		/// <returns>Boolean</returns>
		public static bool IsEven(this int value)
		{
			return value%2 == 0;
		}
	}
}