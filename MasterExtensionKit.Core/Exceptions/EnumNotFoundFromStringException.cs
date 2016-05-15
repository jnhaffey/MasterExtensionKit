using System;

namespace MasterExtensionKit.Core.Exceptions
{
	/// <summary>
	///     Used when no enumeration can be found from the string value
	/// </summary>
	public class EnumNotFoundFromStringException : Exception
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="EnumNotFoundFromStringException" /> class
		/// </summary>
		public EnumNotFoundFromStringException()
		{
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="EnumNotFoundFromStringException" /> class
		/// </summary>
		/// <param name="message">A friendly error message</param>
		public EnumNotFoundFromStringException(string message)
			: base(message)
		{
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="EnumNotFoundFromStringException" /> class
		/// </summary>
		/// <param name="message">A friendly error message</param>
		/// <param name="innerException">An exception that was handled by <see cref="EnumNotFoundFromStringException" /></param>
		public EnumNotFoundFromStringException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}