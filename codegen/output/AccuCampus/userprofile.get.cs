using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Userprofiles.
	/// </summary>
	public static partial class Userprofile
	{
		
		/// <summary>
		/// Gets a specific user profiles.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the profile question set.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "userprofile.get", new {@id
});
		}

		

	}
}


