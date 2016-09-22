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
		/// Saves the profile for a specific (or current) user. Additional security applies on a per questionnaire basis..  This action requires authentication.
		/// </summary>
		/// <param name="@answers">The json object containing the answers, in the format of {key:value, ...}</param>


		public static ActionResult Saveanswers(string @answers
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "userprofile.saveanswers", new {@answers
});
		}

		
		/// <summary>
		/// Saves the profile for a specific (or current) user. Additional security applies on a per questionnaire basis.
		/// </summary>
		/// <param name="@answers">The json object containing the answers, in the format of {key:value, ...}</param>
		/// <param name="@userid">The id of the user to update, or empty for current user.</param>


		public static ActionResult Saveanswers(string @answers, Guid @userid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "userprofile.saveanswers", new {@answers, @userid
});
		}

		

	}
}


