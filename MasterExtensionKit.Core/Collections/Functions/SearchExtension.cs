using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Collections.Functions
{
	/// <summary>
	///     Collection Extension Method
	/// </summary>
	public static class SearchExtension
	{
		/// <summary>
		///     Searches a collection for a term
		/// </summary>
		/// <typeparam name="T">The Collection Type</typeparam>
		/// <param name="source">The collection source</param>
		/// <param name="searchTerm">The term to search for</param>
		/// <returns>The modified collection</returns>
		public static IEnumerable<T> Search<T>(this IEnumerable<T> source, string searchTerm)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var entities = source.ToList();

			// If there are no results, or the search term is blank/empty/null, exit.
			if (!entities.Any() || string.IsNullOrWhiteSpace(searchTerm))
			{
				return entities;
			}

			var returnList = new List<T>();

			var properties =
				entities.First().GetType().GetProperties(BindingFlags.IgnoreCase | BindingFlags.Public
				                                         | BindingFlags.Instance);
			if (!properties.Any())
			{
				return entities;
			}

			// Loop over every property on the object where the property name isn't blank
			foreach (var prop in properties.Where(prop => !string.IsNullOrWhiteSpace(prop.Name)))
			{
				returnList.AddRange(entities.Filter(prop, searchTerm));
			}

			// We MUST call .Distinct() here in order to get rid of things that may have matched more than once, but is in fact the same object
			return returnList.Distinct();
		}
	}
}