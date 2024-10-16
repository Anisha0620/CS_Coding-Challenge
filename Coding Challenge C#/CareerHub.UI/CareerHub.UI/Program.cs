using System;
using CareerHub.BusinessLayer.Service;
using CareerHub.Entity;
using CareerHub.BusinessLayer.Exception;
using CareerHub.BusinessLayer.Repository;

namespace CareerHub.UI
{
	class Program
	{
		private static IApplicantService _applicantService;
		private static IJobService _jobService;
		private static ICompanyService _companyService;

		static void Main(string[] args)
		{
			string connectionString = "Server=.;Database=CareerHubDB;User Id=user;Password=password;";

			// Initialize the services with the repositories
			_applicantService = new ApplicantService(new ApplicantRepository(connectionString));
			_jobService = new JobService(new JobRepository(connectionString));
			_companyService = new CompanyService(new CompanyRepository(connectionString));

			while (true)
			{
				Console.WriteLine("Welcome to CareerHub!");
				Console.WriteLine("1. Register Applicant");
				Console.WriteLine("2. Post Job");
				Console.WriteLine("3. View Job Listings");
				Console.WriteLine("4. View Applicants");
				Console.WriteLine("5. Exit");
				Console.Write("Select an option: ");

				var input = Console.ReadLine();
				switch (input)
				{
					case "1":
						RegisterApplicant();
						break;
					case "2":
						PostJob();
						break;
					case "3":
						ViewJobListings();
						break;
					case "4":
						ViewApplicants();
						break;
					case "5":
						return; // Exit the application
					default:
						Console.WriteLine("Invalid option. Please try again.");
						break;
				}
			}
		}

		private static void RegisterApplicant()
		{
			Console.Write("Enter the Applicant ID: ");
			var applicantID=Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter First Name: ");
			var firstName = Console.ReadLine();
			Console.Write("Enter Last Name: ");
			var lastName = Console.ReadLine();
			Console.Write("Enter Email: ");
			var email = Console.ReadLine();
			Console.Write("Enter Phone: ");
			var phone = Console.ReadLine();

			var applicant = new Applicant
			{
				ApplicantID = applicantID, // Assign a unique ID (this should ideally be auto-generated in a real scenario)
				FirstName = firstName,
				LastName = lastName,
				Email = email,
				Phone = phone
			};

			_applicantService.RegisterApplicant(applicant);
			Console.WriteLine("Applicant registered successfully.");
		}

		private static void PostJob()
		{
			Console.Write("Enter Company ID: ");
			int companyId = int.Parse(Console.ReadLine());

			Console.Write("Enter Job Title: ");
			var jobTitle = Console.ReadLine();

			Console.Write("Enter Job Description: ");
			var jobDescription = Console.ReadLine();

			Console.Write("Enter Job Location: ");
			var jobLocation = Console.ReadLine();

			Console.Write("Enter Salary: ");
			decimal salary = decimal.Parse(Console.ReadLine());

			Console.Write("Enter Job Type: ");
			var jobType = Console.ReadLine();

			var job = new JobListing
			{
				JobID = 1, // Assign a unique ID (this should ideally be auto-generated)
				CompanyID = companyId,
				JobTitle = jobTitle,
				JobDescription = jobDescription,
				JobLocation = jobLocation,
				Salary = salary,
				JobType = jobType,
				PostedDate = DateTime.Now
			};

			_jobService.PostJob(job);
			Console.WriteLine("Job posted successfully.");
		}

		private static void ViewJobListings()
		{
			var jobs = _jobService.GetJobs();
			Console.WriteLine("Job Listings:");
			foreach (var job in jobs)
			{
				Console.WriteLine($"JobID: {job.JobID}, Title: {job.JobTitle}, CompanyID: {job.CompanyID}, Location: {job.JobLocation}, Salary: {job.Salary}, Type: {job.JobType}");
			}
		}

		private static void ViewApplicants()
		{
			var applicants = _applicantService.GetAllApplicants();
			Console.WriteLine("Applicants:");
			foreach (var applicant in applicants)
			{
				Console.WriteLine($"ID: {applicant.ApplicantID}, Name: {applicant.FirstName} {applicant.LastName}, Email: {applicant.Email}, Phone: {applicant.Phone}");
			}
		}
	}
}

