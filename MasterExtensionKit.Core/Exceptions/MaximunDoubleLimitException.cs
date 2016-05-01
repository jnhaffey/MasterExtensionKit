using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterExtensionKit.Core.Exceptions
{
	public class MaximunDoubleLimitException:Exception
	{
		public MaximunDoubleLimitException()
		{
		}

		public MaximunDoubleLimitException(string message)
			: base(message)
		{
		}

		public MaximunDoubleLimitException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}
