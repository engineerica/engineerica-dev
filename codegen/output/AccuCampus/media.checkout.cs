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
		/// Check a media item out.  This action requires authentication.
		/// </summary>
		/// <param name="@media">The id of the media item to checkout.</param>
		/// <param name="@user">The id of the user that is checking the item out.</param>
		/// <param name="@checkoutdate">The checkout date.</param>
		/// <param name="@duedate">The date when the checkout is due.</param>


		public static ActionResult Checkout(Guid @media, Guid @user, DateTime @checkoutdate, DateTime @duedate
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "media.checkout", new {@media, @user, @checkoutdate, @duedate
});
		}

		
		/// <summary>
		/// Check a media item out
		/// </summary>
		/// <param name="@media">The id of the media item to checkout.</param>
		/// <param name="@user">The id of the user that is checking the item out.</param>
		/// <param name="@checkoutdate">The checkout date.</param>
		/// <param name="@duedate">The date when the checkout is due.</param>
		/// <param name="@staff">The id of the staff member related to the checkout.</param>
		/// <param name="@event">The id of the event related to the checkout.</param>
		/// <param name="@notes">The notes of the checkout.</param>


		public static ActionResult Checkout(Guid @media, Guid @user, DateTime @checkoutdate, DateTime @duedate, Guid @staff, Guid @event, string @notes
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "media.checkout", new {@media, @user, @checkoutdate, @duedate, @staff, @event, @notes
});
		}

		

	}
}


