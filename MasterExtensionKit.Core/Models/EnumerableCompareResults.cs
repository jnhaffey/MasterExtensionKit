using System.Collections.Generic;

namespace MasterExtensionKit.Core.Models
{
	public class EnumerableCompareResults<T>
	{
		public IEnumerable<T> AddedRecords { get; set; }
		public IEnumerable<T> RemovedRecords { get; set; }
	}
}