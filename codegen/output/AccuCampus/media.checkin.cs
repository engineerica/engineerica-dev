using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Medias.
	/// </summary>
	public static partial class Media
	{
		
		/// <summary>
		/// Check a media item in.  This action requires authentication.
		/// </summary>
		/// <param name="@media">The id of the media item to checkin.</param>
		/// <param name="@checkindate">The checkout date.</param>


		public static ActionResult Checkin(Guid @media, DateTime @checkindate
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "media.checkin", new {@media, @checkindate
});
		}

		
		/// <summary>
		/// Check a media item in
		/// </summary>
		/// <param name="@media">The id of the media item to checkin.</param>
		/// <param name="@checkindate">The checkout date.</param>
		/// <param name="@notes">The notes of the checkout.</param>


		public static ActionResult Checkin(Guid @media, DateTime @checkindate, string @notes
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "media.checkin", new {@media, @checkindate, @notes
});
		}

		

	}
}


