using System.Collections.Generic;
using System.Data.SqlClient;
using CareerHub.Entity;
using CareerHub.Util;

namespace CareerHub.BusinessLayer.Repository
{
	public class ApplicantRepository : IApplicantRepository
	{
		private readonly string _connectionString;

		public ApplicantRepository(string connectionString)
		{
			_connectionString = connectionString;
		}

		public void AddApplicant(Applicant applicant)
		{
			using (SqlConnection connection = DBConnectionUtil.GetConnection())
			{
				string query = "INSERT INTO Applicants (ApplicantID, FirstName, LastName, Email, Phone) VALUES (@ApplicantID, @FirstName, @LastName, @Email, @Phone)";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@ApplicantID", applicant.ApplicantID);
				command.Parameters.AddWithValue("@FirstName", applicant.FirstName);
				command.Parameters.AddWithValue("@LastName", applicant.LastName);
				command.Parameters.AddWithValue("@Email", applicant.Email);
				command.Parameters.AddWithValue("@Phone", applicant.Phone);

				connection.Open();
				command.ExecuteNonQuery();
			}
		}

		public List<Applicant> GetAllApplicants()
		{
			var applicants = new List<Applicant>();
			using (SqlConnection connection =DBConnectionUtil.GetConnection())
			{
				string query = "SELECT * FROM Applicants";

				SqlCommand command = new SqlCommand(query, connection);
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					var applicant = new Applicant
					{
						ApplicantID = (int)reader["ApplicantID"],
						FirstName = (string)reader["FirstName"],
						LastName = (string)reader["LastName"],
						Email = (string)reader["Email"],
						Phone = (string)reader["Phone"]
					};
					applicants.Add(applicant);
				}
			}
			return applicants;
		}

		public Applicant GetApplicantById(int applicantId)
		{
			// Implement this method as needed to retrieve a specific applicant
			throw new System.NotImplementedException();
		}
	}
}

