using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Getianatimezones.
	/// </summary>
	public static partial class Getianatimezone
	{
		
		/// <summary>
		/// Gets the current time zone's iana name.  This action requires authentication.
		/// </summary>


		public static ActionResult Execute(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "getianatimezone", new {
});
		}

		
		/// <summary>
		/// Gets the current time zone's iana name
		/// </summary>
		/// <param name="@domain">The account's name.</param>


		public static ActionResult Execute(string @domain
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "getianatimezone", new {@domain
});
		}

		

	}
}


