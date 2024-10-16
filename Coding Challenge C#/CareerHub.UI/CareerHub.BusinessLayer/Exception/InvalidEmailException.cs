using System;

namespace CareerHub.BusinessLayer.Exception
{
	public class InvalidEmailException : CustomException
	{
		public InvalidEmailException(string message) : base(message) { }
	}
}
