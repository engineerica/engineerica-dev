using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Conferences.
	/// </summary>
	public static partial class Conference
	{
		
		/// <summary>
		/// Adds a logo to the conference.  This action requires authentication.
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@filename">The original filename, needed to process the file.</param>


		public static ActionResult Addlogo(string @upload, string @filename
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "conference.addlogo", new {@upload, @filename
});
		}

		
		/// <summary>
		/// Adds a logo to the conference
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@filename">The original filename, needed to process the file.</param>
		/// <param name="@conference">The id of the conference whose certificate has to be saved, or null to create a new conference.</param>


		public static ActionResult Addlogo(string @upload, string @filename, string @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "conference.addlogo", new {@upload, @filename, @conference
});
		}

		

	}
}


