using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Datetimes.Validations
{
	/// <summary>
	///     DateTime Extension Method
	/// </summary>
	public static class IsWeekendExtension
	{
		/// <summary>
		///     Evaluates if provided date is a Saturday or Sunday
		/// </summary>
		/// <param name="source">The datetime source</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool IsWeekend(this DateTime source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			return source.DayOfWeek == DayOfWeek.Sunday || source.DayOfWeek == DayOfWeek.Saturday;
		}
	}
}