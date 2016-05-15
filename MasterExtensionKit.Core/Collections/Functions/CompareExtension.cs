using System.Collections.Generic;
using System.Linq;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Models;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Collections.Functions
{
	/// <summary>
	/// Collection Extension Method
	/// </summary>
	public static class CompareExtension
	{
		/// <summary>
		///     Compares two collections of the same type
		/// </summary>
		/// <typeparam name="TSource">Type of Collection</typeparam>
		/// <param name="source">Source Collection</param>
		/// <param name="secondaryCollection">Secondary Collection</param>
		/// <returns type="CollectionCompareResults">Provides list of what is missing in each collection, respectively</returns>
		public static CollectionCompareResults<TSource> Compare<TSource>(this IEnumerable<TSource> source, IEnumerable<TSource> secondaryCollection)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (secondaryCollection.IsNull())
			{
				throw new SourceNullException(nameof(secondaryCollection));
			}

			var results = new CollectionCompareResults<TSource>(
				secondaryCollection.Except(source).ToList(),
				source.Except(secondaryCollection).ToList());
			return results;
		}
	}
}