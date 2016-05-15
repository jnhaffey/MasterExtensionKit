using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Collections.Functions
{
	/// <summary>
	///     Collection Extension Method
	/// </summary>
	public static class WhereIfEnumerableExtensions
	{
		/// <summary>
		///     Executes the predicate, only if the condition is true
		/// </summary>
		/// <typeparam name="TSource">The Source Type</typeparam>
		/// <param name="source">The Collection Source</param>
		/// <param name="condition">The condition flag to execute the predicate</param>
		/// <param name="predicate">The predicate to be executed</param>
		/// <returns>The modified collection</returns>
		public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> source, bool condition, Func<TSource, bool> predicate)
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
		/// <typeparam name="TSource">The Source Type</typeparam>
		/// <param name="source">The Collection Source</param>
		/// <param name="condition">The condition flag to execute the predicate</param>
		/// <param name="predicate">The predicate to be executed</param>
		/// <returns>The modified collection</returns>
		public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> source, bool condition, Expression<Func<TSource, bool>> predicate)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return condition ? source.Where(predicate) : source;
		}
	}
}