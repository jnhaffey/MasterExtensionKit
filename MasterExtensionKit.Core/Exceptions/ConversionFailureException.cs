using System;
using System.Diagnostics.CodeAnalysis;

namespace MasterExtensionKit.Core.Exceptions
{
	[ExcludeFromCodeCoverage]
	public class ConversionFailureException : Exception
	{
		public ConversionFailureException()
		{
		}

		public ConversionFailureException(string message)
			: base(message)
		{
		}

		public ConversionFailureException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}