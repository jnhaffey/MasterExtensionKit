using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MasterExtensionKit.Core.Models
{
	[ExcludeFromCodeCoverage]
	public class EnumerableCompareResults<T>
	{
		public IEnumerable<T> AddedRecords { get; set; }
		public IEnumerable<T> RemovedRecords { get; set; }
	}
}