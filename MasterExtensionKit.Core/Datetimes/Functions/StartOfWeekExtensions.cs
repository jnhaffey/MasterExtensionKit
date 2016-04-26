using System;

namespace MasterExtensionKit.Core.Datetimes.Functions
{
	public static class StartOfWeekExtensions
	{
		/// <summary>
		///     Get the start of the week for the given date
		/// </summary>
		/// <param name="value"></param>
		/// <param name="startOfWeek"></param>
		/// <returns>DateTime</returns>
		public static DateTime StartOfWeek(this DateTime value, DayOfWeek startOfWeek = DayOfWeek.Monday)
		{
			var diff = value.DayOfWeek - startOfWeek;
			if (diff < 0)
			{
				diff += 7;
			}

			return value.AddDays(-1*diff).Date;
		}
	}
}