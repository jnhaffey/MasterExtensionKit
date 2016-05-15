using System;

namespace MasterExtensionKit.Core.Exceptions
{
	/// <summary>
	///     Used when the requested property does not exist
	/// </summary>
	public class PropertyNotFoundException : Exception
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="PropertyNotFoundException" /> class
		/// </summary>
		public PropertyNotFoundException()
		{
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="PropertyNotFoundException" /> class
		/// </summary>
		/// <param name="message">A friendly error message</param>
		public PropertyNotFoundException(string message)
			: base(message)
		{
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="PropertyNotFoundException" /> class
		/// </summary>
		/// <param name="message">A friendly error message</param>
		/// <param name="innerException">An exception that was handled by <see cref="PropertyNotFoundException" /></param>
		public PropertyNotFoundException(string message, Exception innerException)
			: base(message, innerException)
		{
		}
	}
}