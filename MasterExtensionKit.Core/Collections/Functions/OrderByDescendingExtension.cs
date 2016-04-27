using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MasterExtensionKit.Core.Collections.Functions
{
	public static class OrderByDescendingExtension
	{
		public static IEnumerable<T> OrderByDescending<T>(this IEnumerable<T> source, string propertyName)
		{
			var entities = source.ToList();
			if (!entities.Any() || string.IsNullOrEmpty(propertyName) || entities.Count <= 1)
			{
				return entities;
			}

			var propertyInfo = entities.First().GetType().GetProperty(propertyName,
				BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
			return entities.OrderByDescending(e => propertyInfo.GetValue(e, null));
		}
	}
}