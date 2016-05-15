using System;

namespace MasterExtensionKit.Core.Exceptions
{
	/// <summary>
	///     Used when no Enumeration can be found from a Guid
	/// </summary>
	public class EnumNotFoundFromGuidException : Exception
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="EnumNotFoundFromGuidException" /> class
		/// </summary>
		public EnumNotFoundFromGuidException()
		{
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="EnumNotFoundFromGuidException" /> class
		/// </summary>
		/// <param name="message">A friendly error message</param>
		public EnumNotFoundFromGuidException(string message)
			: base(message)
		{
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="EnumNotFoundFromGuidException" /> class
		/// </summary>
		/// <param name="message">A friendly error message</param>
		/// <param name="innerException">An exception that was handled by <see cref="EnumNotFoundFromGuidException" /></param>
		public EnumNotFoundFromGuidException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}