using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Actiontypes.
	/// </summary>
	public static partial class Actiontype
	{
		
		/// <summary>
		/// Get an action type.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the action type to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "actiontype.get", new {@id
});
		}

		

	}
}


