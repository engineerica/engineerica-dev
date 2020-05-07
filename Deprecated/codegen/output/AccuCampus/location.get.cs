using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Locations.
	/// </summary>
	public static partial class Location
	{
		
		/// <summary>
		/// Get location.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the location to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "location.get", new {@id
});
		}

		

	}
}


