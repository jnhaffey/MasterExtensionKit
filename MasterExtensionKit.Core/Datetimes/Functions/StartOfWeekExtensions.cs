using System;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

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
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var diff = source.DayOfWeek - startOfWeek;
			if (diff < 0)
			{
				diff += 7;
			}

			return source.AddDays(-1*diff).Date;
		}
	}
}