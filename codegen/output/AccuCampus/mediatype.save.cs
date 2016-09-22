using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Mediatypes.
	/// </summary>
	public static partial class Mediatype
	{
		
		/// <summary>
		/// Save a media type.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the mediaType.</param>
		/// <param name="@checkoutperiodbasis">The checkout period basis (0 = hours, 1 = days, 2 = weeks).</param>
		/// <param name="@checkoutperiodduration">Specifies the duration of the default checkout period given the basis.</param>


		public static ActionResult Save(string @name, CheckoutPeriodBasis @checkoutperiodbasis, int @checkoutperiodduration
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "mediatype.save", new {@name, @checkoutperiodbasis, @checkoutperiodduration
});
		}

		
		/// <summary>
		/// Save a media type
		/// </summary>
		/// <param name="@name">The name of the mediaType.</param>
		/// <param name="@checkoutperiodbasis">The checkout period basis (0 = hours, 1 = days, 2 = weeks).</param>
		/// <param name="@checkoutperiodduration">Specifies the duration of the default checkout period given the basis.</param>
		/// <param name="@id">The id of the mediaType save (leave empty to create a new one).</param>


		public static ActionResult Save(string @name, CheckoutPeriodBasis @checkoutperiodbasis, int @checkoutperiodduration, Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "mediatype.save", new {@name, @checkoutperiodbasis, @checkoutperiodduration, @id
});
		}

		

	}
}


