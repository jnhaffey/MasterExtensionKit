using System;
using System.Text.RegularExpressions;
using MasterExtensionKit.Core.Configuration;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class GetWordCountExtension
	{
		public static int GetWorldCount(this string source)
		{
			var count = 0;
			try
			{
				var regex = new Regex(RegExpressions.WHITE_SPACE);
				var matches = regex.Matches(source);
				count = matches.Count;
			}
			catch (Exception)
			{
				//TODO: Check what Exceptions can be thrown?
				throw;
			}
			return count;
		}
	}
}