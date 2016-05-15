using System;
using System.Collections.Generic;
using System.Linq;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Collections.Functions
{
	/// <summary>
	///     Collection Extension Method
	/// </summary>
	public static class ShuffleEnumerableExtensions
	{
		/// <summary>
		///     Shuffles the order of the collection
		/// </summary>
		/// <typeparam name="TSource">The Collection Type</typeparam>
		/// <param name="source">The Collection Source</param>
		/// <returns>The modified collection</returns>
		public static IEnumerable<TSource> Shuffle<TSource>(this IEnumerable<TSource> source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var r = new Random((int) DateTime.Now.Ticks);
			var shuffledList = source
				.Select(x => new {Number = r.Next(), Item = x})
				.OrderBy(x => x.Number)
				.Select(x => x.Item);
			return shuffledList.ToList();
		}
	}
}