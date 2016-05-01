using System;
using System.Collections.Generic;
using System.Linq;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

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
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var r = new Random((int) DateTime.Now.Ticks);
			var shuffledList = source.Select(x => new {Number = r.Next(), Item = x}).OrderBy(x => x.Number).Select(x => x.Item);
			return shuffledList.ToList();
		}
	}
}