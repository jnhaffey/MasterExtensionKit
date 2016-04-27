using System.Collections.Generic;
using System.Linq;

namespace MasterExtensionKit.Core.Collections.Functions
{
	public static class PageExtension
	{
		public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageSize, int pageNumber)
		{
			return source.Skip(pageSize*pageNumber).Take(pageSize);
		}
	}
}