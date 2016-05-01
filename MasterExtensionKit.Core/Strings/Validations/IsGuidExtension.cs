using System;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Validations
{
	public static class IsGuidExtension
	{
		/// <summary>
		///     Checks if the given string is a valid Guid
		/// </summary>
		/// <param name="source"></param>
		/// <returns>Boolean</returns>
		/// <summary>
		///     Checks if the given string is a valid Guid
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
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