using System.Collections.Generic;
using System;

namespace CareerHub.Entity
{
	public class JobListing
	{
		public int JobID { get; set; }
		public int CompanyID { get; set; }
		public string JobTitle { get; set; }
		public string JobDescription { get; set; }
		public string JobLocation { get; set; }
		public decimal Salary { get; set; }
		public string JobType { get; set; }
		public DateTime PostedDate { get; set; }

		private List<int> ApplicantIDs
		{
			get; set;  // List of applicant IDs who applied for the job
		}

		public JobListing()
		{
			ApplicantIDs = new List<int>();
		}

		public void Apply(int applicantID, string coverLetter)
		{
			ApplicantIDs.Add(applicantID);
			Console.WriteLine($"Applicant {applicantID} applied for Job {JobID}: {coverLetter}");
		}

		public List<int> GetApplicants()
		{
			return ApplicantIDs;
		}
	}
}


