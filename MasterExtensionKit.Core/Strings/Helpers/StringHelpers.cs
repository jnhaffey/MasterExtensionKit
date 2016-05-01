using System;
using System.IO;
using System.Text;
using MasterExtensionKit.Core.Objects.Validations;
using MasterExtensionKit.Core.Strings.Validations;

namespace MasterExtensionKit.Core.Strings.Helpers
{
	public static class StringHelpers
	{
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
				//TODO: Do better Exception Handling
				throw;
			}
		}
	}
}