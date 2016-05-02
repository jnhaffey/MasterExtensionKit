using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterExtensionKit.Core.UnitTests._Shared
{
	public static class TestDateTimeData
	{
		public static DateTime? NULL_DATETIME = null;
		public static DateTime EMPTY_DATETIME = new DateTime();
		public static readonly DateTime DATETIME_BASE_2015_1_1 = new DateTime(2015, 1, 1);
		public static readonly DateTime TODAY_MINUS_FIVE_YEARS = DateTime.Now.AddYears(-5);
		public static readonly DateTime TODAY_PLUS_FIVE_YEARS = DateTime.Now.AddYears(5);
	}
}
