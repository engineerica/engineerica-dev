using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Userprofiles.
	/// </summary>
	public static partial class Userprofile
	{
		
		/// <summary>
		/// Saves the list of user profiles.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the profile.</param>
		/// <param name="@questions">JSON serialized questions.</param>


		public static ActionResult Save(string @name, string @questions
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "userprofile.save", new {@name, @questions
});
		}

		
		/// <summary>
		/// Saves the list of user profiles
		/// </summary>
		/// <param name="@name">The name of the profile.</param>
		/// <param name="@questions">JSON serialized questions.</param>
		/// <param name="@id">The id of the profile question set.</param>
		/// <param name="@canviewown">Whether the user can view it's own profile.</param>
		/// <param name="@caneditown">Whether the user can edit it's own profile.</param>
		/// <param name="@viewroles">The roles that can view the answers, in JSON format.</param>
		/// <param name="@editroles">The roles that can edit the answers, in JSON format.</param>
		/// <param name="@scopes">The scopes that have access to this questionnaire, in JSON format.</param>


		public static ActionResult Save(string @name, string @questions, Guid @id, bool @canviewown, bool @caneditown, string @viewroles, string @editroles, string @scopes
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "userprofile.save", new {@name, @questions, @id, @canviewown, @caneditown, @viewroles, @editroles, @scopes
});
		}

		

	}
}


