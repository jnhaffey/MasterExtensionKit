using System;
using System.Diagnostics.CodeAnalysis;

namespace MasterExtensionKit.Core.Exceptions
{
	[ExcludeFromCodeCoverage]
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