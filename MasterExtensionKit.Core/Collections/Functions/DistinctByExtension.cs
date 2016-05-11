using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterExtensionKit.Core.Collections.Functions
{
	public static class DistinctByExtension
	{
		public static IEnumerable<TSource> DistinctBy<TSource, TKey>
			(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			var seenKeys = new HashSet<TKey>();
			return source.Where(element => seenKeys.Contains(keySelector(element)));
		}
	}
}