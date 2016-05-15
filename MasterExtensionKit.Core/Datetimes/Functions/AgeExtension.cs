using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Datetimes.Functions
{
	/// <summary>
	///     DateTime Extension Method
	/// </summary>
	public static class AgeExtension
	{
		/// <summary>
		///     Get an age from a source
		/// </summary>
		/// <param name="source">The datetime source</param>
		/// <returns>The age of the datetime source, in years</returns>
		public static int Age(this DateTime source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var today = DateTime.Today;
			if (today.Month < source.Month || (today.Month == source.Month && today.Day < source.Day))
			{
				return today.Year - source.Year - 1;
			}

			return today.Year - source.Year;
		}
	}
}