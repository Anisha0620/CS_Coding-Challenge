using System.Collections.Generic;
using System.Data.SqlClient;
using CareerHub.Entity;
using CareerHub.Util;

namespace CareerHub.BusinessLayer.Repository
{
	public class CompanyRepository : ICompanyRepository
	{
		private readonly string _connectionString;

		public CompanyRepository(string connectionString)
		{
			_connectionString = connectionString;
		}

		public void AddCompany(Company company)
		{
			using (SqlConnection connection = new SqlConnection(_connectionString))
			{
				string query = "INSERT INTO Companies (CompanyID, CompanyName, Location) VALUES (@CompanyID, @CompanyName, @Location)";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@CompanyID", company.CompanyID);
				command.Parameters.AddWithValue("@CompanyName", company.CompanyName);
				command.Parameters.AddWithValue("@Location", company.Location);

				connection.Open();
				command.ExecuteNonQuery();
			}
		}

		public List<Company> GetAllCompanies()
		{
			var companies = new List<Company>();
			using (SqlConnection connection = DBConnectionUtil.GetConnection())
			{
				string query = "SELECT * FROM Companies";

				SqlCommand command = new SqlCommand(query, connection);
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					var company = new Company
					{
						CompanyID = (int)reader["CompanyID"],
						CompanyName = (string)reader["CompanyName"],
						Location = (string)reader["Location"]
					};
					companies.Add(company);
				}
			}
			return companies;
		}

		public Company GetCompanyById(int companyId)
		{
			// Implement this method as needed to retrieve a specific company
			throw new System.NotImplementedException();
		}
	}
}
