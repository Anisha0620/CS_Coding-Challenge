using System.Collections.Generic;
using CareerHub.Entity;

namespace CareerHub.BusinessLayer.Service
{
	public interface IApplicantService
	{
		void RegisterApplicant(Applicant applicant);
		List<Applicant> GetAllApplicants();
		Applicant GetApplicantById(int applicantId);
	}
}


