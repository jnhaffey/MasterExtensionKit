using System.Collections;
using System.Collections.Generic;

namespace MasterExtensionKit.Core.Models
{
	public class CollectionCompareResults<T>
	{
		public ICollection RecordsMissingInSourceCollection { get; set; }
		public ICollection RecordsMissingInSecondaryCollection { get; set; }
	}
}