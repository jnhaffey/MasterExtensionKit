using System.Collections.Generic;
using System.Linq;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Collections.Functions
{
	/// <summary>
	///     Collection Extension Method
	/// </summary>
	public static class PageExtension
	{
		/// <summary>
		///     Reduces the collection to a given page length and given page
		/// </summary>
		/// <typeparam name="T">The Collection Type</typeparam>
		/// <param name="source">The collection source</param>
		/// <param name="pageSize">The size of each page</param>
		/// <param name="pageNumber">The page wanting to be returned</param>
		/// <returns>The modified collection</returns>
		public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageSize = 10, int pageNumber = 1)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var evenPageCount = source.Count()%pageSize;
			var maxPageNumber = source.Count()/(pageSize + (evenPageCount == 0 ? 0 : 1));
			if (maxPageNumber < pageNumber)
			{
				throw new PageOutOfRangeException($"The max page available for this collection is '{maxPageNumber}'");
			}

			var adjustedPageNumber = pageNumber - 1;

			return source.Skip(pageSize*adjustedPageNumber).Take(pageSize);
		}
	}
}