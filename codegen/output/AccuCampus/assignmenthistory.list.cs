using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Assignmenthistorys.
	/// </summary>
	public static partial class Assignmenthistory
	{
		
		/// <summary>
		/// List action assignment history.  This action requires authentication.
		/// </summary>
		/// <param name="@actionassignment">The action assignment's id whose history the user wants to get.</param>


		public static ActionResult List(Guid @actionassignment
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "assignmenthistory.list", new {@actionassignment
});
		}

		

	}
}


