using System;
using System.Text;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.StringBuilders.Functions;
using MasterExtensionKit.Core.UnitTests._Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MasterExtensionKit.Core.UnitTests.StringBuilders.Functions
{
	[TestClass]
	public class AppendLineIfExtensionUnitTests
	{
		private StringBuilder _builder;

		#region General String Tests

		[TestMethod]
		[ExpectedException(typeof(SourceNullException), "")]
		public void StringBuilder_Function_AppendLineIf_Null_Exception()
		{
			_builder.AppendLineIf(true,TestStringData.ALPHA_ONLY_STRING);
		}

		#endregion

		[TestMethod]
		public void StringBuilder_Function_AppendLineIf_True_Valid()
		{
			_builder = new StringBuilder();
			_builder.AppendLineIf(true, TestStringData.ALPHA_ONLY_STRING);
			Assert.AreEqual($"{TestStringData.ALPHA_ONLY_STRING}{Environment.NewLine}", _builder.ToString());
		}

		[TestMethod]
		public void StringBuilder_Function_AppendLineIf_False_Valid()
		{
			_builder = new StringBuilder();
			_builder.AppendLineIf(false, TestStringData.ALPHA_ONLY_STRING);
			Assert.AreEqual(String.Empty, _builder.ToString());
		}
	}
}
