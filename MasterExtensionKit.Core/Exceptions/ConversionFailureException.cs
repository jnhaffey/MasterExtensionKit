using System;

namespace MasterExtensionKit.Core.Exceptions
{
	public class ConversionFailureException : Exception
	{
		public ConversionFailureException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}