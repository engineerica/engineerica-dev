using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Newsletters.
	/// </summary>
	public static partial class Newsletter
	{
		
		/// <summary>
		/// Adds a logo to the conference.  This action requires authentication.
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@filename">The original filename, needed to process the file.</param>
		/// <param name="@finalwidth">The final width of the ad.</param>
		/// <param name="@finalheight">The final height of the ad.</param>


		public static ActionResult Uploadbanner(string @upload, string @filename, int @finalwidth, int @finalheight
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "newsletter.uploadbanner", new {@upload, @filename, @finalwidth, @finalheight
});
		}

		

	}
}


