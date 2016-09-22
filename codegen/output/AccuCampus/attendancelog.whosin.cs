using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Gets the attendance logs of the users that are signed-in.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult Whosin(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "attendancelog.whosin", new {@from, @count
});
		}

		
		/// <summary>
		/// Gets the attendance logs of the users that are signed-in
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@location">The id of the location to search for users that are in.</param>
		/// <param name="@event">The id of the event to search for users that are in.</param>
		/// <param name="@roles">The comma-separated list of ids of the roles to search for users that are in.</param>
		/// <param name="@photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
		/// <param name="@extensions">A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]).</param>


		public static ActionResult Whosin(int @from, int @count, Guid @location, Guid @event, string @roles, int @photosize, string @extensions
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "attendancelog.whosin", new {@from, @count, @location, @event, @roles, @photosize, @extensions
});
		}

		

	}
}


