using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;
using MasterExtensionKit.Core.Strings.Functions;

namespace MasterExtensionKit.Core.Collections.Functions
{
	public static class FilterExtensions
	{
		public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, string propertyName, string value)
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
				.GetProperty(propertyName,
					BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
			return entities.Where(e =>
			{
				var val = propertyInfo.GetValue(e, null);
				return val != null && val.ToString().ContainsCultureInvariant(value);
			});
		}

		public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, PropertyInfo propInfo, string value)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var entities = source.ToList();
			if (!entities.Any() || propInfo == null || string.IsNullOrWhiteSpace(value))
			{
				return entities;
			}

			return entities.Where(e => {
				var val = propInfo.GetValue(e, null);
				return val != null && val.ToString().ContainsCultureInvariant(value);
			});
		}
	}
}