using System;

namespace MasterExtensionKit.Core.Exceptions
{
	/// <summary>
	///     Used when a conversion fails
	/// </summary>
	public class ConversionFailureException : Exception
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ConversionFailureException" /> class
		/// </summary>
		public ConversionFailureException()
		{
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="ConversionFailureException" /> class
		/// </summary>
		/// <param name="message">A friendly error message</param>
		public ConversionFailureException(string message)
			: base(message)
		{
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="ConversionFailureException" /> class
		/// </summary>
		/// <param name="message">A friendly error message</param>
		/// <param name="innerException">An exception that was handled by <see cref="ConversionFailureException" /></param>
		public ConversionFailureException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}