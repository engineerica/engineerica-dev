using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Workshopregs.
	/// </summary>
	public static partial class Workshopreg
	{
		
		/// <summary>
		/// Get the workshops of the specified conference available for online registration.  This action requires authentication.
		/// </summary>


		public static ActionResult Onlinelist(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshopreg.onlinelist", new {
});
		}

		
		/// <summary>
		/// Get the workshops of the specified conference available for online registration
		/// </summary>
		/// <param name="@domain">The account's domain.</param>
		/// <param name="@conference">The id of the conference whose rooms have to be returned. If not specified the 'next' conference will be used.</param>


		public static ActionResult Onlinelist(string @domain, string @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshopreg.onlinelist", new {@domain, @conference
});
		}

		

	}
}


