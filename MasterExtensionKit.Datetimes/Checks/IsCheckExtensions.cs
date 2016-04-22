using System;

namespace MasterExtensionKit.Datetimes.Checks
{
	public static class IsCheckExtensions
	{
		/// <summary>
		///     Checks if provided date is a Saturday or Sunday
		/// </summary>
		/// <param name="value"></param>
		/// <returns>True or False</returns>
		public static bool IsWeekend(this DateTime value)
		{
			return value.DayOfWeek == DayOfWeek.Sunday || value.DayOfWeek == DayOfWeek.Saturday;
		}
	}
}