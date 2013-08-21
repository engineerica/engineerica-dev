using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Bgjobs.
	/// </summary>
	public partial class Bgjob : ActionSet
	{
		
		/// <summary>
		/// Get background job status.  This action requires authentication.
		/// </summary>


		public ActionResult Getstatus(
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "bgjob.getstatus", new {
});
		}

		
		/// <summary>
		/// Get background job status
		/// </summary>
		/// <param name="_jobid">The ID of the job to get the status. 10 most recent will be returned if not specified.</param>
		/// <param name="_jobtype">The job type to filter by.</param>


		public ActionResult Getstatus(Guid _jobid, string _jobtype
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "bgjob.getstatus", new {_jobid, _jobtype
});
		}

		

	}
}


