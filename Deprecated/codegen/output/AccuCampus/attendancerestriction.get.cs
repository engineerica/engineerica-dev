using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Attendancerestrictions.
	/// </summary>
	public static partial class Attendancerestriction
	{
		
		/// <summary>
		/// View an attendance restriction.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the restriction to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "attendancerestriction.get", new {@id
});
		}

		

	}
}


