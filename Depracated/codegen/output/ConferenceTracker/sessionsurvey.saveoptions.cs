using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Sessionsurveys.
	/// </summary>
	public static partial class Sessionsurvey
	{
		
		/// <summary>
		/// Saves sessionSurvey.  This action requires authentication.
		/// </summary>
		/// <param name="@enabled">Sets whether session surveys are enabled or not.</param>
		/// <param name="@commentsenabled">Sets whether session surveys comments are enabled or not.</param>
		/// <param name="@questions">JSON array containing the list of questions, with Id, Position and Text.</param>


		public static ActionResult Saveoptions(bool @enabled, bool @commentsenabled, bool @questions
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "sessionsurvey.saveoptions", new {@enabled, @commentsenabled, @questions
});
		}

		

	}
}


