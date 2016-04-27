using System;

namespace MasterExtensionKit.Core.Exceptions
{
	public class UnknownOrUnsupportedOptionException : Exception
	{
		public UnknownOrUnsupportedOptionException()
		{
		}

		public UnknownOrUnsupportedOptionException(string message)
			: base(message)
		{
		}

		public UnknownOrUnsupportedOptionException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}