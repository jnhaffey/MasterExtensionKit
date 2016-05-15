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
	public static class FilterExactExtension
	{
		/// <summary>
		///     Filters the collection based on the given property and value tightly
		/// </summary>
		/// <typeparam name="T">The Collection Type</typeparam>
		/// <param name="source">The Collection Source</param>
		/// <param name="propertyName">The property name</param>
		/// <param name="value">The value of the property</param>
		/// <returns>The modified collection</returns>
		public static IEnumerable<T> FilterExact<T>(this IEnumerable<T> source, string propertyName, string value)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var entities = source.ToList();
			if (!entities.Any() || string.IsNullOrEmpty(propertyName) || string.IsNullOrWhiteSpace(value))
			{
				return entities;
			}

			var propertyInfo = entities.First()
				.GetType()
				.GetProperty(
					propertyName,
					BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

			if (propertyInfo == null)
			{
				throw new PropertyNotFoundException($"Unable to find property '{propertyName}' in type '{typeof(T)}'");
			}

			return entities.Where(e =>
			{
				var val = propertyInfo.GetValue(e, null);
				return val != null && val.ToString().Equals(value);
			});
		}
	}
}