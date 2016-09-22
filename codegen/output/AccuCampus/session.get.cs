using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Sessions.
	/// </summary>
	public static partial class Session
	{
		
		/// <summary>
		/// Gets the session with the specified id.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the session to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "session.get", new {@id
});
		}

		

	}
}


