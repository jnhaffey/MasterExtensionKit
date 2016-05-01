using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Converters
{
	public static class ToDateTimeExtension
	{
		/// <summary>
		///     Attempts to convert a string to a DateTime object
		/// </summary>
		/// <param name="source"></param>
		/// <returns>Nullable DateTime</returns>
		public static DateTime? ToDateTime(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			DateTime datetime;
			var parseResult = DateTime.TryParse(source, out datetime);
			return parseResult ? datetime : new DateTime?();
		}
	}
}