using System;

namespace CareerHub.BusinessLayer.Exception
{
	public class ApplicationDeadlineException : CustomException
	{
		public ApplicationDeadlineException(string message) : base(message) { }
	}
}
