using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Newsletters.
	/// </summary>
	public static partial class Newsletter
	{
		
		/// <summary>
		/// Saves a newsletter ad.  This action requires authentication.
		/// </summary>
		/// <param name="@newsletter">Id of the newsletter where to save the ad.</param>
		/// <param name="@adid">Id of the ad type to create the newsletter.</param>
		/// <param name="@publishedprice">The previous price shown to the user</param>
		/// <param name="@title">Title of the ad to create.</param>
		/// <param name="@text">Text of the ad to create.</param>
		/// <param name="@linktext">Text of the button next to the ad</param>
		/// <param name="@link">Link of the ad.</param>


		public static ActionResult Savead(Guid @newsletter, Guid @adid, decimal @publishedprice, string @title, string @text, string @linktext, string @link
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "newsletter.savead", new {@newsletter, @adid, @publishedprice, @title, @text, @linktext, @link
});
		}

		
		/// <summary>
		/// Saves a newsletter ad
		/// </summary>
		/// <param name="@newsletter">Id of the newsletter where to save the ad.</param>
		/// <param name="@adid">Id of the ad type to create the newsletter.</param>
		/// <param name="@publishedprice">The previous price shown to the user</param>
		/// <param name="@title">Title of the ad to create.</param>
		/// <param name="@text">Text of the ad to create.</param>
		/// <param name="@linktext">Text of the button next to the ad</param>
		/// <param name="@link">Link of the ad.</param>
		/// <param name="@image">Id of the image previously uploaded with newsletter.uploadbanner</param>


		public static ActionResult Savead(Guid @newsletter, Guid @adid, decimal @publishedprice, string @title, string @text, string @linktext, string @link, Guid @image
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "newsletter.savead", new {@newsletter, @adid, @publishedprice, @title, @text, @linktext, @link, @image
});
		}

		

	}
}


