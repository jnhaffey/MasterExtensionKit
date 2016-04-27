using System;

namespace MasterExtensionKit.Core.Exceptions
{
	public class ConversionFailureException : Exception
	{
		public ConversionFailureException()
		{
		}

		public ConversionFailureException(string message) : base(message)
		{
		}

		public ConversionFailureException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}