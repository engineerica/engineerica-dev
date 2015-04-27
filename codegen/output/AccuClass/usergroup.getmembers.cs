using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Usergroups.
	/// </summary>
	public static partial class Usergroup
	{
		
		/// <summary>
		/// Gets a user group by Id.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the user group to get.</param>


		public static ActionResult Getmembers(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "usergroup.getmembers", new {@id
});
		}

		

	}
}


