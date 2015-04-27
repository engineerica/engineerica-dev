using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Userprofiles.
	/// </summary>
	public static partial class Userprofile
	{
		
		/// <summary>
		/// Deletes a user profile.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the user profile to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "userprofile.delete", new {@id
});
		}

		

	}
}


