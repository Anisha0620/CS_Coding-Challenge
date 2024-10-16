using System;

namespace CareerHub.BusinessLayer.Exception
{
	public class SalaryCalculationException : CustomException
	{
		public SalaryCalculationException(string message) : base(message) { }
	}
}
