using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Eventregs.
	/// </summary>
	public static partial class Eventreg
	{
		
		/// <summary>
		/// Lists the users registered to all events.  This action requires authentication.
		/// </summary>
		/// <param name="@listname">The name of the list to get.</param>


		public static ActionResult Getuserstoall(string @listname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "eventreg.getuserstoall", new {@listname
});
		}

		

	}
}


