using System;

namespace MasterExtensionKit.Core.Datetimes.Validations
{
	public static class IsWeekendExtension
	{
		/// <summary>
		///     Checks if provided date is a Saturday or Sunday
		/// </summary>
		/// <param name="source"></param>
		/// <returns>True or False</returns>
		public static bool IsWeekend(this DateTime source)
		{
			return source.DayOfWeek == DayOfWeek.Sunday || source.DayOfWeek == DayOfWeek.Saturday;
		}
	}
}