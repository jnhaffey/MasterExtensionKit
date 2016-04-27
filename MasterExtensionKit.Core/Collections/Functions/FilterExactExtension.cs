using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MasterExtensionKit.Core.Collections.Functions
{
	public static class FilterExactExtension
	{
		public static IEnumerable<T> FilterExact<T>(this IEnumerable<T> source, string propertyName, string value)
		{
			var entities = source.ToList();
			if (!entities.Any() || string.IsNullOrEmpty(propertyName) || string.IsNullOrWhiteSpace(value))
			{
				return entities;
			}

			var propertyInfo = entities.First()
				.GetType()
				.GetProperty(propertyName,
					BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
			return entities.Where(e =>
			{
				var val = propertyInfo.GetValue(e, null);
				return val != null && val.ToString().Equals(value);
			});
		}
	}
}