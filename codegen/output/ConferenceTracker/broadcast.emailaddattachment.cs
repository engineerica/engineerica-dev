using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Broadcasts.
	/// </summary>
	public static partial class Broadcast
	{
		
		/// <summary>
		/// Uploads a file to be later send by email..  This action requires authentication.
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>


		public static ActionResult Emailaddattachment(string @upload
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "broadcast.emailaddattachment", new {@upload
});
		}

		
		/// <summary>
		/// Uploads a file to be later send by email.
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@filename">The local name of the uploaded file. For later reference.</param>


		public static ActionResult Emailaddattachment(string @upload, string @filename
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "broadcast.emailaddattachment", new {@upload, @filename
});
		}

		

	}
}


