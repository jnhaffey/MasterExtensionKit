namespace MasterExtensionKit.Core.Enumerations
{
	/// <summary>
	///     Supported hash algorithms
	/// </summary>
	public enum HashType
	{
		// REMOVING THESE UNIT TESTS AS THE HASHES ARE UNABLE TO BE TESTED
		/*
		HMAC,
		HMACMD5,
		HMACSHA1,
		HMACSHA256,
		HMACSHA384,
		HMACSHA512,
		MACTripleDES,
		*/
		MD5,
		RIPEMD160,
		SHA1,
		SHA256,
		SHA384,
		SHA512
	}
}