using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Locations.
	/// </summary>
	public static partial class Location
	{
		
		/// <summary>
		/// Deletes a location.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the location to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "location.delete", new {@id
});
		}

		

	}
}


