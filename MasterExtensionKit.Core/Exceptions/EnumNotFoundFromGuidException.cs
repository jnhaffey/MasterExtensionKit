using System;
using System.Diagnostics.CodeAnalysis;

namespace MasterExtensionKit.Core.Exceptions
{
	[ExcludeFromCodeCoverage]
	public class EnumNotFoundFromGuidException : Exception
	{
		public EnumNotFoundFromGuidException()
		{
		}

		public EnumNotFoundFromGuidException(string message)
			: base(message)
		{
		}

		public EnumNotFoundFromGuidException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}