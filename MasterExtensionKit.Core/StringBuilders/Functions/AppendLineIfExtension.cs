using System.Text;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.StringBuilders.Functions
{
	/// <summary>
	///     StringBuilder Extension Method
	/// </summary>
	public static class AppendLineIfExtension
	{
		/// <summary>
		///     Conditionally Append a line to a StringBuilder
		/// </summary>
		/// <param name="source">The stringbuilder source</param>
		/// <param name="condition">The condition to include</param>
		/// <param name="value">The string value to append</param>
		/// <returns>The updated stringbuilder source</returns>
		public static StringBuilder AppendLineIf(this StringBuilder source, bool condition, string value)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (condition)
			{
				source.AppendLine(value);
			}

			return source;
		}
	}
}