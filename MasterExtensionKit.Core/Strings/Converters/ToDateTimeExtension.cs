using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;
using MasterExtensionKit.Core.Strings.Validations;

namespace MasterExtensionKit.Core.Strings.Converters
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class ToDateTimeExtension
	{
		/// <summary>
		///     Attempts to convert a string to a DateTime object
		/// </summary>
		/// <param name="source">The string source</param>
		/// <returns>A nullable DateTime</returns>
		public static DateTime? ToDateTime(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (!source.HasValue())
			{
				throw new SourceEmptyException(nameof(source));
			}

			DateTime datetime;
			var parseResult = DateTime.TryParse(source, out datetime);
			return parseResult ? datetime : new DateTime?();
		}
	}
}