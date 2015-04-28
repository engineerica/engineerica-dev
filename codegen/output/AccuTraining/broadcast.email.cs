using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Broadcasts.
	/// </summary>
	public static partial class Broadcast
	{
		
		/// <summary>
		/// Send a massive email to several people..  This action requires authentication.
		/// </summary>
		/// <param name="@sendto">One of the send-to flags.</param>
		/// <param name="@subject">Args depending on the send-to flag.</param>
		/// <param name="@body">Args depending on the send-to flag.</param>


		public static ActionResult Email(string @sendto, string @subject, string @body
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "broadcast.email", new {@sendto, @subject, @body
});
		}

		
		/// <summary>
		/// Send a massive email to several people.
		/// </summary>
		/// <param name="@sendto">One of the send-to flags.</param>
		/// <param name="@subject">Args depending on the send-to flag.</param>
		/// <param name="@body">Args depending on the send-to flag.</param>
		/// <param name="@args">Args depending on the send-to flag.</param>
		/// <param name="@from">The name of the sender to be displayed in the receipients inbox</param>
		/// <param name="@replyto">The reply-to field for the emails.</param>


		public static ActionResult Email(string @sendto, string @subject, string @body, string @args, string @from, string @replyto
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "broadcast.email", new {@sendto, @subject, @body, @args, @from, @replyto
});
		}

		

	}
}


