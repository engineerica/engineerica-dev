using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Userprofiles.
	/// </summary>
	public static partial class Userprofile
	{
		
		/// <summary>
		/// Shows the profile for a specific (or current) user, based on each profile questionnaire questions..  This action requires authentication.
		/// </summary>


		public static ActionResult Getallview(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "userprofile.getallview", new {
});
		}

		
		/// <summary>
		/// Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
		/// </summary>
		/// <param name="@id">The id of the user to view, or empty for current user.</param>


		public static ActionResult Getallview(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "userprofile.getallview", new {@id
});
		}

		

	}
}


