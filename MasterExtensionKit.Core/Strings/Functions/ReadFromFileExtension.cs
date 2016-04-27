using System;
using System.IO;
using System.Text;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Functions
{
	public static class ReadFromFileExtension
	{
		public static void ReadFromFile(this string source, string fileName, Encoding encodingType = null)
		{
			if (encodingType.IsNull())
			{
				encodingType = Encoding.Default;
			}
			try
			{
				using (var streamReader = new StreamReader(fileName, encodingType))
				{
					source = streamReader.ReadToEnd();
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