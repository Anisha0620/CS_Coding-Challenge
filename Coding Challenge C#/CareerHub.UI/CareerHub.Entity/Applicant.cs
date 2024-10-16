using System;

namespace CareerHub.Entity
{
	public class Applicant
	{
		public int ApplicantID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Resume { get; set; }

		public void CreateProfile(string email, string firstName, string lastName, string phone)
		{
			Email = email;
			FirstName = firstName;
			LastName = lastName;
			Phone = phone;
			Console.WriteLine("Profile created successfully.");
		}

		public void ApplyForJob(int jobID, string coverLetter)
		{
			// Logic for applying for a job (could call JobListing.Apply)
			Console.WriteLine($"Applicant {FirstName} {LastName} applied for Job ID {jobID} with cover letter: {coverLetter}");
		}
	}
}

