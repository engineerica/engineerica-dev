using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Accountlinkss.
	/// </summary>
	public static partial class Accountlinks
	{
		
		/// <summary>
		/// Copies the configuration from the specified account to the current one.  This action requires authentication.
		/// </summary>
		/// <param name="@fromaccountid">The ID of the account to copy the settings from.</param>


		public static ActionResult Copyconfigs(Guid @fromaccountid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "accountlinks.copyconfigs", new {@fromaccountid
});
		}

		
		/// <summary>
		/// Copies the configuration from the specified account to the current one
		/// </summary>
		/// <param name="@fromaccountid">The ID of the account to copy the settings from.</param>
		/// <param name="@copytemplates">Whether to copy templates from current account.</param>
		/// <param name="@copysettings">Whether to copy settings from current account.</param>
		/// <param name="@copyadmins">Whether to copy admin accounts from current account, besides the current one.</param>


		public static ActionResult Copyconfigs(Guid @fromaccountid, bool @copytemplates, bool @copysettings, bool @copyadmins
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "accountlinks.copyconfigs", new {@fromaccountid, @copytemplates, @copysettings, @copyadmins
});
		}

		

	}
}


