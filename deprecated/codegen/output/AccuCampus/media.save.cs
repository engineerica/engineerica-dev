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
		/// Save a media item.  This action requires authentication.
		/// </summary>
		/// <param name="@title">The title of the media item.</param>
		/// <param name="@mediatype">The type of the media item.</param>
		/// <param name="@checkoutperiodbasis">The checkout period basis (0 = hours, 1 = days, 2 = weeks).</param>
		/// <param name="@checkoutperiodduration">Specifies the duration of the checkout period given the basis.</param>
		/// <param name="@active">Specifies whether the media item is active or not.</param>


		public static ActionResult Save(string @title, Guid @mediatype, CheckoutPeriodBasis @checkoutperiodbasis, int @checkoutperiodduration, bool @active
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "media.save", new {@title, @mediatype, @checkoutperiodbasis, @checkoutperiodduration, @active
});
		}

		
		/// <summary>
		/// Save a media item
		/// </summary>
		/// <param name="@title">The title of the media item.</param>
		/// <param name="@mediatype">The type of the media item.</param>
		/// <param name="@checkoutperiodbasis">The checkout period basis (0 = hours, 1 = days, 2 = weeks).</param>
		/// <param name="@checkoutperiodduration">Specifies the duration of the checkout period given the basis.</param>
		/// <param name="@active">Specifies whether the media item is active or not.</param>
		/// <param name="@id">The id of the media item save (leave empty to create a new one).</param>
		/// <param name="@code">The code of the media item.</param>
		/// <param name="@location">The location of the media item.</param>
		/// <param name="@staff">The staff of the media item.</param>
		/// <param name="@shelf">The shelf of the media item.</param>
		/// <param name="@notes">The notes of the media item.</param>


		public static ActionResult Save(string @title, Guid @mediatype, CheckoutPeriodBasis @checkoutperiodbasis, int @checkoutperiodduration, bool @active, Guid @id, string @code, Guid @location, Guid @staff, string @shelf, string @notes
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "media.save", new {@title, @mediatype, @checkoutperiodbasis, @checkoutperiodduration, @active, @id, @code, @location, @staff, @shelf, @notes
});
		}

		

	}
}


