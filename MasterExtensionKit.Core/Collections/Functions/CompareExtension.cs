using System.Collections.Generic;
using System.Linq;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Models;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Collections.Functions
{
	public static class CompareExtension
	{
		/// <summary>
		///     Compares two collections of the same type
		/// </summary>
		/// <typeparam name="T">Type of Collection</typeparam>
		/// <param name="source">Source Collection</param>
		/// <param name="secondaryCollection">Secondary Collection</param>
		/// <returns type="CollectionCompareResults&lt;T&gt;">Provides list of what is missing in each collection, respectively</returns>
		public static CollectionCompareResults<T> Compare<T>(this IEnumerable<T> source, IEnumerable<T> secondaryCollection)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (secondaryCollection.IsNull())
			{
				throw new SourceNullException(nameof(secondaryCollection));
			}

			var results = new CollectionCompareResults<T>
			{
				RecordsMissingInSourceCollection = secondaryCollection.Except(source).ToList(),
				RecordsMissingInSecondaryCollection = source.Except(secondaryCollection).ToList()
			};
			return results;
		}
	}
}