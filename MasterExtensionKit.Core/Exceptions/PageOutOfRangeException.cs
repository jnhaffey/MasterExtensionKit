using System;

namespace MasterExtensionKit.Core.Exceptions
{
	/// <summary>
	///     Used when a request is out of the current page range
	/// </summary>
	public class PageOutOfRangeException : Exception
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="PageOutOfRangeException" /> class
		/// </summary>
		public PageOutOfRangeException()
		{
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="PageOutOfRangeException" /> class
		/// </summary>
		/// <param name="message">A friendly error message</param>
		public PageOutOfRangeException(string message)
			: base(message)
		{
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="PageOutOfRangeException" /> class
		/// </summary>
		/// <param name="message">A friendly error message</param>
		/// <param name="innerException">An exception that was handled by <see cref="PageOutOfRangeException" /></param>
		public PageOutOfRangeException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}