using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "location.delete", new {@id
});
		}

		

	}
}


