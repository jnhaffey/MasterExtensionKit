using System;

namespace MasterExtensionKit.Core.Exceptions
{
	public class SourceNullException : ArgumentNullException
	{
		public SourceNullException()
		{
		}

		public SourceNullException(string message)
			: base(message)
		{
		}

		public SourceNullException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}