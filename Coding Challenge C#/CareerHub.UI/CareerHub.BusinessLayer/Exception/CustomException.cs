using System;

namespace CareerHub.BusinessLayer.Exception
{
	public class CustomException : global::System.Exception 
	{
		// Default constructor
		public CustomException() : base("An error occurred in the application.") { }

		// Constructor with a message
		public CustomException(string message) : base(message) { }

		// Constructor with a message and an inner exception
		public CustomException(string message,System.Exception inner) : base(message, inner) { }
	}
}
