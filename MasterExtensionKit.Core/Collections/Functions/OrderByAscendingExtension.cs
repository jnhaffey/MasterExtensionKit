using System;
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
	public static class OrderByAscendingExtension
	{
		/// <summary>
		///     Orders the collection by the provided Property in Ascending Order
		/// </summary>
		/// <typeparam name="TSource">The Collection Type</typeparam>
		/// <param name="source">The Collection Source</param>
		/// <param name="propertyName">The property to sort on</param>
		/// <returns>The modified collection</returns>
		public static IEnumerable<TSource> OrderByAscending<TSource>(this IEnumerable<TSource> source, string propertyName)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (propertyName.IsNull())
			{
				throw new ArgumentNullException(nameof(propertyName));
			}

			var entities = source.ToList();
			if (!entities.Any() || string.IsNullOrEmpty(propertyName) || entities.Count <= 1)
			{
				return entities;
			}

			var propertyInfo = entities.First()
				.GetType()
				.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

			if (propertyInfo == null)
			{
				throw new PropertyNotFoundException($"Unable to find property '{propertyName}' in type '{typeof(TSource)}'");
			}

			return entities.OrderBy(e => propertyInfo.GetValue(e, null));
		}
	}
}