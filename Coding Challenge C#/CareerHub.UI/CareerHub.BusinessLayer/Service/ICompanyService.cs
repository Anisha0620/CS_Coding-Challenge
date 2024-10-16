using System.Collections.Generic;
using CareerHub.Entity;

namespace CareerHub.BusinessLayer.Service
{
	public interface ICompanyService
	{
		void RegisterCompany(Company company);
		List<Company> GetAllCompanies();
		Company GetCompanyById(int companyId);
	}
}


