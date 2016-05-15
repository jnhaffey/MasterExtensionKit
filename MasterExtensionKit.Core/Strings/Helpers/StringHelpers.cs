using System;
using System.IO;
using System.Text;
using MasterExtensionKit.Core.Objects.Validations;
using MasterExtensionKit.Core.Strings.Validations;

namespace MasterExtensionKit.Core.Strings.Helpers
{
	/// <summary>
	///     String Helper Static Class
	/// </summary>
	public static class StringHelpers
	{
		/// <summary>
		///     Reads all data from a given file
		/// </summary>
		/// <param name="returnValue">String that is returned (OUT)</param>
		/// <param name="fileName">Location and File Name</param>
		/// <param name="encodingType">Optional: Encoding Type</param>
		public static void ReadFromFile(out string returnValue, string fileName, Encoding encodingType = null)
		{
			if (!fileName.HasValue())
			{
				throw new ArgumentNullException(nameof(fileName));
			}

			if (encodingType.IsNull())
			{
				encodingType = Encoding.Default;
			}

			try
			{
				using (var streamReader = new StreamReader(fileName, encodingType))
				{
					returnValue = streamReader.ReadToEnd();
					streamReader.Close();
				}
			}
			catch (Exception)
			{
				// TODO: Do better Exception Handling
				throw;
			}
		}
	}
}