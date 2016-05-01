using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Collections.Functions
{
	public static class WhereIfEnumerableExtensions
	{
		/// <summary>
		///     Executes the predicate, only if the condition is true
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <param name="source"></param>
		/// <param name="condition"></param>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> source, bool condition,
			Func<TSource, bool> predicate)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return condition ? source.Where(predicate) : source;
		}

		/// <summary>
		///     Executes the predicate, only if the condition is true
		/// </summary>
		/// <typeparam name="TSource"></typeparam>
		/// <param name="source"></param>
		/// <param name="condition"></param>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> source, bool condition,
			Expression<Func<TSource, bool>> predicate)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return condition ? source.Where(predicate) : source;
		}
	}
}