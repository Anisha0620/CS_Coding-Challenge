using System.Collections.Generic;
using CareerHub.Entity;

namespace CareerHub.BusinessLayer.Repository
{
	public interface ICompanyRepository
	{
		void AddCompany(Company company);
		List<Company> GetAllCompanies();
		Company GetCompanyById(int companyId);
	}
}
