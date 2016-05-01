﻿using System;
using MasterExtensionKit.Core.Configuration;
using MasterExtensionKit.Core.Exceptions;
using MasterExtensionKit.Core.Objects.Validations;

namespace MasterExtensionKit.Core.Strings.Converters
{
	public static class ToDecimalExtension
	{
		/// <summary>
		///     Convert a string to a decimal
		/// </summary>
		/// <param name="source"></param>
		/// <param name="ignoreError"></param>
		/// <returns></returns>
		public static decimal? ToDecimal(this string source, bool ignoreError = true)
		{
			if (source.IsNull())
			{
				throw new SourceNullException(nameof(source));
			}

			decimal? valueToReturn = null;
			try
			{
				valueToReturn = decimal.Parse(source);
			}
			catch (Exception ex)
			{
				if (ignoreError)
				{
					return null;
				}
				throw new ConversionFailureException(ErrorMessages.GenerateConversionError("string", "decimal"), ex);
			}
			return valueToReturn;
		}
	}
}