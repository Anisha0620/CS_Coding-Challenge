using System.Collections.Generic;
using CareerHub.Entity;
using CareerHub.BusinessLayer.Repository;

namespace CareerHub.BusinessLayer.Service
{
	public class CompanyService : ICompanyService // Ensure it implements ICompanyService
	{
		private readonly ICompanyRepository _companyRepository;

		public CompanyService(ICompanyRepository companyRepository)
		{
			_companyRepository = companyRepository;
		}

		public void RegisterCompany(Company company)
		{
			_companyRepository.AddCompany(company);
		}

		public List<Company> GetAllCompanies()
		{
			return _companyRepository.GetAllCompanies();
		}

		public Company GetCompanyById(int companyId)
		{
			return _companyRepository.GetCompanyById(companyId);
		}
	}
}


