using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterExtensionKit.Core.Collections.Functions
{
	public static class ShuffleEnumerableExtensions
	{
		/// <summary>
		///     Shuffles the order of the collection
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <param name="source"></param>
		/// <returns></returns>
		public static IEnumerable<TSource> Shuffle<TSource>(this IEnumerable<TSource> source)
		{
			var r = new Random((int) DateTime.Now.Ticks);
			var shuffledList = source.Select(x => new {Number = r.Next(), Item = x}).OrderBy(x => x.Number).Select(x => x.Item);
			return shuffledList.ToList();
		}
	}
}