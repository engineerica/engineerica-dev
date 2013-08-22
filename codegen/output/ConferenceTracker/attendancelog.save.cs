using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Attendancelogs.
	/// </summary>
	public static partial class Attendancelog
	{
		
		/// <summary>
		/// Saves an attendance log.  This action requires authentication.
		/// </summary>
		/// <param name="@date">The date in ISO format.</param>
		/// <param name="@workshop">The id of the workshop where the user signed in.</param>
		/// <param name="@user">The id of the user.</param>


		public static ActionResult Save(DateTime @date, Guid @workshop, Guid @user
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "attendancelog.save", new {@date, @workshop, @user
});
		}

		
		/// <summary>
		/// Saves an attendance log
		/// </summary>
		/// <param name="@date">The date in ISO format.</param>
		/// <param name="@workshop">The id of the workshop where the user signed in.</param>
		/// <param name="@user">The id of the user.</param>
		/// <param name="@id">The id of the room to save (leave empty to create a new one).</param>
		/// <param name="@logdetails">The log details in JSON format</param>


		public static ActionResult Save(DateTime @date, Guid @workshop, Guid @user, Guid @id, Guid @logdetails
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "attendancelog.save", new {@date, @workshop, @user, @id, @logdetails
});
		}

		

	}
}


