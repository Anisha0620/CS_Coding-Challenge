using System.Collections.Generic;
using CareerHub.Entity;

namespace CareerHub.BusinessLayer.Repository
{
	public interface IJobRepository
	{
		void AddJob(JobListing job);
		List<JobListing> GetJobs();
		JobListing GetJobById(int jobId);
	}
}

