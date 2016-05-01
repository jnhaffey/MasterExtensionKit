using System.Collections.Generic;
using System.Linq;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Collections.Functions
{
	public static class PageExtension
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <param name="pageSize"></param>
		/// <param name="pageNumber"></param>
		/// <returns></returns>
		public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageSize = 10, int pageNumber = 1)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source.Skip(pageSize*pageNumber).Take(pageSize);
		}
	}
}