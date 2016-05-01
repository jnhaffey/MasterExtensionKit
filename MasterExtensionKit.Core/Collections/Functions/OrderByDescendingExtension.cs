using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Collections.Functions
{
	public static class OrderByDescendingExtension
	{
		/// <summary>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <param name="propertyName"></param>
		/// <returns></returns>
		public static IEnumerable<T> OrderByDescending<T>(this IEnumerable<T> source, string propertyName)
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

			var propertyInfo = entities.First().GetType().GetProperty(propertyName,
				BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
			return entities.OrderByDescending(e => propertyInfo.GetValue(e, null));
		}
	}
}