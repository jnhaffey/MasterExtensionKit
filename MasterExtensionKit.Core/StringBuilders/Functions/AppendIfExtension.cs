using System.Text;

namespace MasterExtensionKit.Core.StringBuilders.Functions
{
	public static class AppendIfExtension
	{
		/// <summary>
		///     Append to a StringBuilder conditionally
		/// </summary>
		/// <param name="source"></param>
		/// <param name="condition"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static StringBuilder AppendIf(this StringBuilder source, bool condition, string value)
		{
			if (condition)
			{
				source.Append(value);
			}
			return source;
		}
	}
}