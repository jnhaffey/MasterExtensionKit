namespace MasterExtensionKit.Core.Configuration
{
	/// <summary>
	///     Static Regular Expression Store
	/// </summary>
	internal static class RegExpressions
	{
		/// <summary>
		///     Used for IP Address Default Validation
		/// </summary>
		internal const string IP_ADDRESS =
			@"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";

		/// <summary>
		///     Used for Email Default Validation
		/// </summary>
		internal const string EMAIL = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

		/// <summary>
		///     Used for White Space Checks
		/// </summary>
		internal const string WHITE_SPACE = @"[^\s]+";

		#region POSTAL CODES

		/// <summary>
		///     Used for United States Postal Code Default Validation
		/// </summary>
		internal const string POSTAL_CODE_UNITED_STATES = @"^\d{5}(?:[-\s]\d{4})?$";

		/// <summary>
		///     Used for United Kingdom Postal Code Default
		/// </summary>
		internal const string POSTAL_CODE_UNITED_KINGDOM = @"^(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|"
		                                                   + "(([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|"
		                                                   + "(([A-Z-[QVX]][0-9][A-HJKPSTUW])|"
		                                                   +
		                                                   "([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY])))) [0-9][A-Z-[CIKMOV]]{2})$";

		#endregion
	}
}