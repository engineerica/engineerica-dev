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
		/// Delete an attendance restriction.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the restriction to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "attendancerestriction.delete", new {@id
});
		}

		

	}
}


