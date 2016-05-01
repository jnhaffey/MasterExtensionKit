using System.Collections.Generic;
using System.Linq;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Collections.Functions
{
	public static class RangeExtension
	{
		public static IEnumerable<T> Range<T>(this IEnumerable<T> source, int startIndex, int endIndex)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source.Skip(startIndex).Take(endIndex - startIndex);
		}
	}
}