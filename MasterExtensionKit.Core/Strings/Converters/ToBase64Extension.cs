using System;
using System.Text;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Converters
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class ToBase64Extension
	{
		/// <summary>
		///     Converts the given string to a Base64 string
		/// </summary>
		/// <param name="source">The string source</param>
		/// <returns>Base64 String</returns>
		public static string ToBase64(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var encoding = new ASCIIEncoding();
			return Convert.ToBase64String(encoding.GetBytes(source));
		}
	}
}