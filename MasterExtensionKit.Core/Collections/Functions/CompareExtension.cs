using System.Collections.Generic;
using System.Linq;
using MasterExtensionKit.Core.Models;

namespace MasterExtensionKit.Core.Collections.Functions
{
	public static class CompareExtension
	{
		public static EnumerableCompareResults<T> Compare<T>(this IEnumerable<T> source1, IEnumerable<T> source2)
		{
			var results = new EnumerableCompareResults<T>
			{
				AddedRecords = source2.Except(source1).ToList(),
				RemovedRecords = source1.Except(source2).ToList()
			};
			return results;
		}
	}
}