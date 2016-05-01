using System;

namespace MasterExtensionKit.Core.UnitTests._Shared
{
	public static class TestSharedData
	{
		#region File Related Strings

		public static readonly string TEST_FILE_LOCATION = $"{AppDomain.CurrentDomain.BaseDirectory}\\";
		public const string TEST_FILE_NAME = @"SaveToFileTest.txt";
		public static readonly string TEST_FILE_LOCATION_FILE_NAME = TEST_FILE_LOCATION + TEST_FILE_NAME;

		#endregion
	}
}