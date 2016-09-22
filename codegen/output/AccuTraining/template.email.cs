using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Templates.
	/// </summary>
	public static partial class Template
	{
		
		/// <summary>
		/// Send generated templates by email for a specific job..  This action requires authentication.
		/// </summary>
		/// <param name="@jobid">The id of the job that is creating the templates.</param>
		/// <param name="@emailsubject">Args depending on the send-to flag.</param>
		/// <param name="@emailbody">Args depending on the send-to flag.</param>


		public static ActionResult Email(string @jobid, string @emailsubject, string @emailbody
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "template.email", new {@jobid, @emailsubject, @emailbody
});
		}

		
		/// <summary>
		/// Send generated templates by email for a specific job.
		/// </summary>
		/// <param name="@jobid">The id of the job that is creating the templates.</param>
		/// <param name="@emailsubject">Args depending on the send-to flag.</param>
		/// <param name="@emailbody">Args depending on the send-to flag.</param>
		/// <param name="@templatekind">The kind of the template you're sending. It must be included in (badge, certificate).</param>
		/// <param name="@emailfrom">The name of the sender to be displayed in the receipients inbox</param>
		/// <param name="@emailreplyto">The reply-to field for the emails.</param>


		public static ActionResult Email(string @jobid, string @emailsubject, string @emailbody, string @templatekind, string @emailfrom, string @emailreplyto
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "template.email", new {@jobid, @emailsubject, @emailbody, @templatekind, @emailfrom, @emailreplyto
});
		}

		

	}
}


