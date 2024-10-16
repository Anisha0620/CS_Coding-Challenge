using System.Collections.Generic;
using CareerHub.Entity;

namespace CareerHub.BusinessLayer.Service
{
	public interface IJobService
	{
		void PostJob(JobListing job);
		List<JobListing> GetJobs();
		JobListing GetJobById(int jobId);
	}
}


