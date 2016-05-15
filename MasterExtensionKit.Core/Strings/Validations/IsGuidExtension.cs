using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Validations
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class IsGuidExtension
	{
		/// <summary>
		///     Will validate if a string is a valid Guid
		/// </summary>
		/// <param name="source">The string source</param>
		/// <returns>Boolean indicating if it passes or not</returns>
		public static bool IsGuid(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			Guid value;
			return Guid.TryParse(source, out value);
		}
	}
}