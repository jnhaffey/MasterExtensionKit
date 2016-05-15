using System;
using System.IO;
using System.Text;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;
using MasterExtensionKit.Core.Strings.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	/// <summary>
	///     String Extension Method
	/// </summary>
	public static class SaveToFileExtension
	{
		/// <summary>
		///     Saves the string value to a given file
		/// </summary>
		/// <param name="source">The string source</param>
		/// <param name="fileName">Location and File Name</param>
		/// <param name="append">Optional: Append file</param>
		/// <param name="encoderType">Optional: Encoding Type</param>
		/// <returns>Boolean indicating if the data was successfully saved</returns>
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
			catch
			{
				// TODO: Make better Exception Handling
				throw;
			}

			return true;
		}
	}
}