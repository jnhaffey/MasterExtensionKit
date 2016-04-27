using System;

namespace MasterExtensionKit.Core.Strings.Converters
{
	public static class ToEnumExtension
	{
		/// <summary>
		///     Converts a string to an enum
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <returns></returns>
		public static T ToEnum<T>(this string source) where T : struct
		{
			return (T) Enum.Parse(typeof (T), source, true);
		}
	}
}