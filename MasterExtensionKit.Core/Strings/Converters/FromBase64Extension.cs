using System;
using System.Text;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Converters
{
	public static class FromBase64Extension
	{
		public static string FromBase64(this string source)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}
			
			var encoding = new ASCIIEncoding();
			return encoding.GetString(Convert.FromBase64String(source));
		}
	}
}