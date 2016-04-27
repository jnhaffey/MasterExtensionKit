using System;

namespace MasterExtensionKit.Core.Datetimes.Functions
{
	public static class AgeExtension
	{
		/// <summary>
		///     Get an age from a source
		/// </summary>
		/// <param name="source"></param>
		/// <returns>Years</returns>
		public static int Age(this DateTime source)
		{
			var today = DateTime.Today;
			if (today.Month < source.Month || today.Month == source.Month && today.Day < source.Day)
			{
				return today.Year - source.Year - 1;
			}
			return today.Year - source.Year;
		}
	}
}