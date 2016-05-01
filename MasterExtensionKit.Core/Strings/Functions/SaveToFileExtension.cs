using System;
using System.IO;
using System.Text;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;
using MasterExtensionKit.Core.Strings.Validations;

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
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			if (!fileName.HasValue())
			{
				throw new ArgumentNullException(nameof(fileName));
			}

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
			catch (Exception ex)
			{
				//TODO: Do better Exception Handling
				throw;
			}
			return true;
		}
	}
}