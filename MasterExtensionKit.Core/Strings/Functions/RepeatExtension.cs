using System;
using System.Text;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class RepeatExtension
	{
		public static string Repeat(this string source, int count)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (count.IsNull())
			{
				throw new ArgumentNullException(nameof(count));
			}

			if (count <= 0)
			{
				throw new UnknownOrUnsupportedOptionException(ErrorMessages.UnsupportedNumericValueError(nameof(count),count.ToString()));
			}

			var stringBuilder = new StringBuilder();
			for (var i = 0; i < count; i++)
			{
				stringBuilder.Append(source);
			}
			return stringBuilder.ToString();
		}
	}
}