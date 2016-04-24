using System;

namespace MasterExtensionKit.Datetimes.Functions
{
	public static class AgeExtension
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
	}
}