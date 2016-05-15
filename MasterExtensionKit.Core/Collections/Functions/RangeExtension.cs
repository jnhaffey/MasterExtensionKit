using System;
using System.Collections.Generic;
using System.Linq;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Collections.Functions
{
	/// <summary>
	///     Collection Extension Method
	/// </summary>
	public static class RangeExtension
	{
		/// <summary>
		///     Reduces the collection to the given range
		/// </summary>
		/// <typeparam name="T">The Collection Type</typeparam>
		/// <param name="source">The collection source</param>
		/// <param name="startIndex">The start of the range</param>
		/// <param name="endIndex">The end of the range</param>
		/// <returns>The modified collection</returns>
		public static IEnumerable<T> Range<T>(this IEnumerable<T> source, int startIndex, int endIndex)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (startIndex < 0)
			{
				throw new IndexOutOfRangeException($"StartIndex cannot be less than zero (0)");
			}

			var startingIndex = startIndex == 0 ? 0 : startIndex - 1;
			var takeCount = endIndex - startingIndex;
			return source.Skip(startingIndex).Take(takeCount);
		}
	}
}