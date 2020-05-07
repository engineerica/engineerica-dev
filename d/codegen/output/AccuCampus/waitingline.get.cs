using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Waitinglines.
	/// </summary>
	public static partial class Waitingline
	{
		
		/// <summary>
		/// Get a waiting line.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the waiting line to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "waitingline.get", new {@id
});
		}

		
		/// <summary>
		/// Get a waiting line
		/// </summary>
		/// <param name="@id">The id of the waiting line to get.</param>
		/// <param name="@photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>


		public static ActionResult Get(Guid @id, int @photosize
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "waitingline.get", new {@id, @photosize
});
		}

		

	}
}


