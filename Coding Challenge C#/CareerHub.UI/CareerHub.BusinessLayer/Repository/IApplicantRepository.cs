using System.Collections.Generic;
using CareerHub.Entity;

namespace CareerHub.BusinessLayer.Repository
{
	public interface IApplicantRepository
	{
		void AddApplicant(Applicant applicant);
		List<Applicant> GetAllApplicants();
		Applicant GetApplicantById(int applicantId);
	}
}
