using System.Collections;
using System.Collections.Generic;

namespace MasterExtensionKit.Core.Models
{
	/// <summary>
	///     Response Object for Comparing Collections
	/// </summary>
	public class CollectionCompareResults
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="CollectionCompareResults" /> class
		/// </summary>
		/// <param name="missingSorceRecords">The missing records from the source collection</param>
		/// <param name="missingSecondaryRecords">The missing records from the secondary collection</param>
		public CollectionCompareResults(ICollection missingSorceRecords, ICollection missingSecondaryRecords)
		{
			this.RecordsMissingInSourceCollection = missingSorceRecords;
			this.RecordsMissingInSecondaryCollection = missingSecondaryRecords;
		}

		/// <summary>
		///     Gets the records in secondary collection not found in source collection
		/// </summary>
		public ICollection RecordsMissingInSourceCollection { get; private set; }

		/// <summary>
		///     Gets the records in source collection not found in secondary collection
		/// </summary>
		public ICollection RecordsMissingInSecondaryCollection { get; private set; }
	}

	/// <summary>
	///     Get Response object for comparing Generic Enumerable Objects
	/// </summary>
	/// <typeparam name="T">Object</typeparam>
	public class CollectionCompareResults<T>
	{
		/// <summary>
		///		Initializes a new instance of the <see cref="CollectionCompareResults" /> class
		/// </summary>
		/// <param name="missingSorceRecords">The missing records from the source collection</param>
		/// <param name="missingSecondaryRecords">The missing records from the secondary collection</param>
		public CollectionCompareResults(IEnumerable<T> missingSorceRecords, IEnumerable<T> missingSecondaryRecords)
		{
			this.RecordsMissingInSourceCollection = missingSorceRecords;
			this.RecordsMissingInSecondaryCollection = missingSecondaryRecords;
		}

		/// <summary>
		///     Gets the records in secondary collection not found in source collection
		/// </summary>
		public IEnumerable<T> RecordsMissingInSourceCollection { get; private set; }

		/// <summary>
		///     Gets the records in source collection not found in secondary collection
		/// </summary>
		public IEnumerable<T> RecordsMissingInSecondaryCollection { get; private set; }
	}
}