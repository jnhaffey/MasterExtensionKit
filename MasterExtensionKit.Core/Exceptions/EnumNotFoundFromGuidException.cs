using System;

namespace MasterExtensionKit.Core.Exceptions
{
	public class EnumNotFoundFromGuidException : Exception
	{
		public EnumNotFoundFromGuidException()
		{
		}

		public EnumNotFoundFromGuidException(string message) : base(message)
		{
		}

		public EnumNotFoundFromGuidException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}