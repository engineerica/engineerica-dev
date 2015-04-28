using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Actionpacks.
	/// </summary>
	public static partial class Actionpack
	{
		
		/// <summary>
		/// Delete an action pack.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the action pack to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "actionpack.delete", new {@id
});
		}

		

	}
}


