using System;

namespace MasterExtensionKit.Core.Exceptions
{
	/// <summary>
	///     Used when an unknown or unsupported option is provided
	/// </summary>
	public class UnknownOrUnsupportedOptionException : Exception
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="UnknownOrUnsupportedOptionException" /> class
		/// </summary>
		public UnknownOrUnsupportedOptionException()
		{
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="UnknownOrUnsupportedOptionException" /> class
		/// </summary>
		/// <param name="message">A friendly error message</param>
		public UnknownOrUnsupportedOptionException(string message)
			: base(message)
		{
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="UnknownOrUnsupportedOptionException" /> class
		/// </summary>
		/// <param name="message">A friendly error message</param>
		/// <param name="innerException">An exception that was handled by <see cref="UnknownOrUnsupportedOptionException" /></param>
		public UnknownOrUnsupportedOptionException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}