using System;
using System.IO;
using System.Text;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class SaveToFileExtension
	{
		/// <summary>
		///     Saves the string value to file
		/// </summary>
		/// <param name="source"></param>
		/// <param name="fileName"></param>
		/// <param name="append"></param>
		/// <param name="encoderType"></param>
		/// <returns></returns>
		public static bool SaveToFile(this string source, string fileName, bool append = false, Encoding encoderType = null)
		{
			if (encoderType.IsNull())
			{
				encoderType = Encoding.Default;
			}
			try
			{
				using (var streamwriter = new StreamWriter(fileName, append, encoderType))
				{
					streamwriter.Write(source);
					streamwriter.Flush();
					streamwriter.Close();
				}
			}
			catch (Exception)
			{
				//TODO: Do better Exception Handling
				throw;
			}
			return true;
		}
	}
}