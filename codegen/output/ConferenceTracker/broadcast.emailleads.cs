using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Broadcasts.
	/// </summary>
	public static partial class Broadcast
	{
		
		/// <summary>
		/// Send a massive email to the leads collected by your company..  This action requires authentication.
		/// </summary>
		/// <param name="@subject">Args depending on the send-to flag.</param>
		/// <param name="@body">Args depending on the send-to flag.</param>


		public static ActionResult Emailleads(string @subject, string @body
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "broadcast.emailleads", new {@subject, @body
});
		}

		
		/// <summary>
		/// Send a massive email to the leads collected by your company.
		/// </summary>
		/// <param name="@subject">Args depending on the send-to flag.</param>
		/// <param name="@body">Args depending on the send-to flag.</param>
		/// <param name="@args">Args depending on the send-to flag.</param>
		/// <param name="@from">The name of the sender to be displayed in the receipients inbox</param>
		/// <param name="@cc">Cc address(es)</param>
		/// <param name="@replyto">The reply-to field for the emails.</param>
		/// <param name="@attachments">Array of items with 'id' and 'name' of the files to attach.</param>


		public static ActionResult Emailleads(string @subject, string @body, string @args, string @from, string @cc, string @replyto, string @attachments
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "broadcast.emailleads", new {@subject, @body, @args, @from, @cc, @replyto, @attachments
});
		}

		

	}
}


