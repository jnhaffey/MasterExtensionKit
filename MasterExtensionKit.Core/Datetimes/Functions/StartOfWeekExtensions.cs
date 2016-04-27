using System;

namespace MasterExtensionKit.Core.Datetimes.Functions
{
	public static class StartOfWeekExtensions
	{
		/// <summary>
		///     Get the start of the week for the given date
		/// </summary>
		/// <param name="source"></param>
		/// <param name="startOfWeek"></param>
		/// <returns>DateTime</returns>
		public static DateTime StartOfWeek(this DateTime source, DayOfWeek startOfWeek = DayOfWeek.Monday)
		{
			var diff = source.DayOfWeek - startOfWeek;
			if (diff < 0)
			{
				diff += 7;
			}

			return source.AddDays(-1*diff).Date;
		}
	}
}