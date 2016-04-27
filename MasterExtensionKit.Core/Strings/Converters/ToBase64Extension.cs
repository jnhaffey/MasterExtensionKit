using System;
using System.Text;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Converters
{
	public static class ToBase64Extension
	{
		public static string ToBase64(this string source)
		{
			if (source.IsNull())
			{
				throw new ArgumentNullException(nameof(source));
			}
			var encoding = new ASCIIEncoding();
			return Convert.ToBase64String(encoding.GetBytes(source));
		}
	}
}