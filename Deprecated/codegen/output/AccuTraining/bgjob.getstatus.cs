using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Bgjobs.
	/// </summary>
	public static partial class Bgjob
	{
		
		/// <summary>
		/// Get background job status.  This action requires authentication.
		/// </summary>


		public static ActionResult Getstatus(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "bgjob.getstatus", new {
});
		}

		
		/// <summary>
		/// Get background job status
		/// </summary>
		/// <param name="@jobid">The ID of the job to get the status. 10 most recent will be returned if not specified.</param>
		/// <param name="@jobtype">The job type to filter by.</param>


		public static ActionResult Getstatus(Guid @jobid, string @jobtype
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "bgjob.getstatus", new {@jobid, @jobtype
});
		}

		

	}
}


