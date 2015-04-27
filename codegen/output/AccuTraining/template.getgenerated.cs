using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Templates.
	/// </summary>
	public static partial class Template
	{
		
		/// <summary>
		/// Gets generated templates for a specific job..  This action requires authentication.
		/// </summary>
		/// <param name="@jobid">The id of the job that is creating the templates.</param>


		public static ActionResult Getgenerated(string @jobid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "template.getgenerated", new {@jobid
});
		}

		

	}
}


