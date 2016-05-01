using System;
using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class GetWordCountExtension
	{
		public static int GetWordCount(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			var count = 0;
			try
			{
				var regex = new Regex(RegExpressions.WHITE_SPACE);
				var matches = regex.Matches(source);
				count = matches.Count;
			}
			catch (Exception ex)
			{
				//TODO: Check what Exceptions can be thrown?
				throw;
			}
			return count;
		}
	}
}