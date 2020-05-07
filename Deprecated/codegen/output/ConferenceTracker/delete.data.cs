using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Deletes.
	/// </summary>
	public static partial class Delete
	{
		
		/// <summary>
		/// Deletes all the data from the account..  This action requires authentication.
		/// </summary>
		/// <param name="@deletelogs">True to delete the log-ins, attendance logs or swipes.</param>
		/// <param name="@deleteattendees">True to delete the log-ins, attendance logs or swipes.</param>
		/// <param name="@deletesessions">True to delete the log-ins, attendance logs or swipes.</param>
		/// <param name="@confirmpwd">The current user password.</param>


		public static ActionResult Data(bool @deletelogs, bool @deleteattendees, bool @deletesessions, string @confirmpwd
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "delete.data", new {@deletelogs, @deleteattendees, @deletesessions, @confirmpwd
});
		}

		

	}
}


