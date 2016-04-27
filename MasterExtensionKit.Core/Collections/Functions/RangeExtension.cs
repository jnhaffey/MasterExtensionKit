using System.Collections.Generic;
using System.Linq;

namespace MasterExtensionKit.Core.Collections.Functions
{
	public static class RangeExtension
	{
		public static IEnumerable<T> Range<T>(this IEnumerable<T> source, int startIndex, int endIndex)
		{
			return source.Skip(startIndex).Take(endIndex - startIndex);
		}
	}
}