using System.Collections.Generic;
using CareerHub.Entity;
using CareerHub.BusinessLayer.Repository;

namespace CareerHub.BusinessLayer.Service
{
	public class JobService : IJobService // Ensure it implements IJobService
	{
		private readonly IJobRepository _jobRepository;

		public JobService(IJobRepository jobRepository)
		{
			_jobRepository = jobRepository;
		}

		public void PostJob(JobListing job)
		{
			_jobRepository.AddJob(job);
		}

		public List<JobListing> GetJobs()
		{
			return _jobRepository.GetJobs();
		}

		public JobListing GetJobById(int jobId)
		{
			return _jobRepository.GetJobById(jobId);
		}
	}
}
