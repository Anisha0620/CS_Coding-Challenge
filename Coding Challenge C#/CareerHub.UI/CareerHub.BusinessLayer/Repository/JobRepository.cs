using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CareerHub.Entity;
using CareerHub.Util;

namespace CareerHub.BusinessLayer.Repository
{
	public class JobRepository : IJobRepository
	{
		private readonly string _connectionString;

		public JobRepository(string connectionString)
		{
			_connectionString = connectionString;
		}

		public void AddJob(JobListing job)
		{
			using (SqlConnection connection = new SqlConnection(_connectionString))
			{
				string query = "INSERT INTO Jobs (JobID, CompanyID, JobTitle, JobDescription, JobLocation, Salary, JobType) VALUES (@JobID, @CompanyID, @JobTitle, @JobDescription, @JobLocation, @Salary, @JobType)";

				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@JobID", job.JobID);
				command.Parameters.AddWithValue("@CompanyID", job.CompanyID);
				command.Parameters.AddWithValue("@JobTitle", job.JobTitle);
				command.Parameters.AddWithValue("@JobDescription", job.JobDescription);
				command.Parameters.AddWithValue("@JobLocation", job.JobLocation);
				command.Parameters.AddWithValue("@Salary", job.Salary);
				command.Parameters.AddWithValue("@JobType", job.JobType);

				connection.Open();
				command.ExecuteNonQuery();
			}
		}

		public List<JobListing> GetJobs()
		{
			var jobs = new List<JobListing>();
			using (SqlConnection connection = DBConnectionUtil.GetConnection())
			{
				string query = "SELECT * FROM Jobs";

				SqlCommand command = new SqlCommand(query, connection);
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					var job = new JobListing
					{
						JobID = (int)reader["JobID"],
						CompanyID = (int)reader["CompanyID"],
						JobTitle = (string)reader["JobTitle"],
						JobDescription = (string)reader["JobDescription"],
						JobLocation = (string)reader["JobLocation"],
						Salary = (decimal)reader["Salary"],
						JobType = (string)reader["JobType"],
						PostedDate = (DateTime)reader["PostedDate"]
					};
					jobs.Add(job);
				}
			}
			return jobs;
		}

		public JobListing GetJobById(int jobId)
		{
			// Implement this method as needed to retrieve a specific job
			throw new System.NotImplementedException();
		}
	}
}

