using System;
using System.Text;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class RepeatExtension
	{
		public static string Repeat(this string source, int count)
		{
			if (count.IsNull())
			{
				throw new ArgumentNullException(nameof(count));
			}

			var stringBuilder = new StringBuilder();
			for (var i = 0; i < count; i++)
			{
				stringBuilder.AppendLine(source);
			}
			return stringBuilder.ToString();
		}
	}
}