using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterExtensionKit.Core.Exceptions
{
	public class MininumDoubleLimitException: Exception
	{
		public MininumDoubleLimitException()
		{
		}

		public MininumDoubleLimitException(string message)
			: base(message)
		{
		}

		public MininumDoubleLimitException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
