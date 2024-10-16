using System.Collections.Generic;
using CareerHub.Entity;
using CareerHub.BusinessLayer.Repository;

namespace CareerHub.BusinessLayer.Service
{
	public class ApplicantService : IApplicantService // Ensure it implements IApplicantService
	{
		private readonly IApplicantRepository _applicantRepository;

		public ApplicantService(IApplicantRepository applicantRepository)
		{
			_applicantRepository = applicantRepository;
		}

		public void RegisterApplicant(Applicant applicant)
		{
			_applicantRepository.AddApplicant(applicant);
		}

		public List<Applicant> GetAllApplicants()
		{
			return _applicantRepository.GetAllApplicants();
		}

		public Applicant GetApplicantById(int applicantId)
		{
			return _applicantRepository.GetApplicantById(applicantId);
		}
	}
}


