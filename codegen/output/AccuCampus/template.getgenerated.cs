using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "template.getgenerated", new {@jobid
});
		}

		

	}
}


