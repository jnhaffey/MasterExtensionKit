namespace MasterExtensionKit.Core.Configuration
{
	internal static class RegExpressions
	{
		internal const string UNITED_STATES = @"^\d{5}(?:[-\s]\d{4})?$";

		internal const string UNITED_KINGDOM = @"^(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|"
		                                       + "(([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|"
		                                       + "(([A-Z-[QVX]][0-9][A-HJKPSTUW])|"
		                                       + "([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY])))) [0-9][A-Z-[CIKMOV]]{2})$";

		internal const string IP_ADDRESS_REG_EXPRESSION =
			@"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";

		internal const string EMAIL_REG_EXPRESSION = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

		internal const string GUID_REG_EXPRESSION = @"^[{(]?[0-9A-Fa-f]{8}[-]?([0-9A-Fa-f]{4}[-]?){3}[0-9A-Fa-f]{12}[)}]?$";

		internal const string WHITE_SPACE = @"[^\s]+";
	}
}