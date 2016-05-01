using System;

namespace MasterExtensionKit.Core.Exceptions
{
	public class EnumNotFoundFromStringException : Exception
	{
		public EnumNotFoundFromStringException()
		{
		}

		public EnumNotFoundFromStringException(string message)
			: base(message)
		{
		}

		public EnumNotFoundFromStringException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}