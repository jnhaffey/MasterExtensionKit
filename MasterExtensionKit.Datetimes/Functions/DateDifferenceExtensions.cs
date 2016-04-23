using System;

namespace MasterExtensionKit.Datetimes.Functions
{
	public static class DateDifferenceExtensions
	{
		/// <summary>
		///     Get an age from a date
		/// </summary>
		/// <param name="date"></param>
		/// <returns>Years</returns>
		public static int Age(this DateTime date)
		{
			var today = DateTime.Today;
			if (today.Month < date.Month || today.Month == date.Month && today.Day < date.Day)
			{
				return today.Year - date.Year - 1;
			}
			return today.Year - date.Year;
		}

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