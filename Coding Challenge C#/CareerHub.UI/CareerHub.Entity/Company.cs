using System.Collections.Generic;
using System;

namespace CareerHub.Entity
{
	public class Company
	{
		public int CompanyID { get; set; }
		public string CompanyName { get; set; }
		public string Location { get; set; }

		private List<JobListing> JobListings
		{
			get; set;
		} // List of job listings posted by the company


		public Company()
		{
			JobListings = new List<JobListing>();
		}

		public void PostJob(string jobTitle, string jobDescription, string jobLocation, decimal salary, string jobType)
		{
			var jobListing = new JobListing
			{
				JobID = JobListings.Count + 1, // Simple incrementing logic for job ID
				CompanyID = this.CompanyID,
				JobTitle = jobTitle,
				JobDescription = jobDescription,
				JobLocation = jobLocation,
				Salary = salary,
				JobType = jobType,
				PostedDate = DateTime.Now // Set the current date as posted date
			};

			JobListings.Add(jobListing);
			Console.WriteLine($"Job posted: {jobTitle} by {CompanyName}");
		}

		public List<JobListing> GetJobs()
		{
			return JobListings; // Return list of job listings posted by the company
		}
	}
}


