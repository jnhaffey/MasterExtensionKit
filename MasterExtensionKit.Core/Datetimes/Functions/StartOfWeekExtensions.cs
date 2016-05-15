using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Datetimes.Functions
{
	/// <summary>
	///     DateTime Extension Method
	/// </summary>
	public static class StartOfWeekExtensions
	{
		/// <summary>
		///     Get the start of the week for the given date
		/// </summary>
		/// <param name="source">The datetime source</param>
		/// <param name="startOfWeek">Optional: DayOfWeek to start the week</param>
		/// <returns>DateTime for the start of the week for the source datetime</returns>
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