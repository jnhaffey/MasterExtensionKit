using System;
using System.Collections.Generic;

namespace MasterExtensionKit.Core.Collections.Functions
{
	/// <summary>
	///     Collection Extension Method
	/// </summary>
	public static class DistinctByExtension
	{
		/// <summary>
		///     Gets a distinct collection based on the key selector
		/// </summary>
		/// <typeparam name="TSource">The Collection Type</typeparam>
		/// <typeparam name="TKey">The Key Type</typeparam>
		/// <param name="source">The Collection Source</param>
		/// <param name="keySelector">The Selection Key</param>
		/// <returns>The modified collection of Distinct Values</returns>
		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			var seenKeys = new HashSet<TKey>();
			foreach (var element in source)
			{
				var key = keySelector(element);
				if (!seenKeys.Contains(key))
				{
					seenKeys.Add(key);
					yield return element;
				}
			}
		}
	}
}