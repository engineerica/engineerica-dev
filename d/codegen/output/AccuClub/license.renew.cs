using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Licenses.
	/// </summary>
	public static partial class License
	{
		
		/// <summary>
		/// Sends a renewal request for the current account.  This action requires authentication.
		/// </summary>
		/// <param name="@email">The e-mail of the user sending the request.</param>
		/// <param name="@phonenumber">The phone number of the user sending the request.</param>


		public static ActionResult Renew(string @email, string @phonenumber
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "license.renew", new {@email, @phonenumber
});
		}

		
		/// <summary>
		/// Sends a renewal request for the current account
		/// </summary>
		/// <param name="@email">The e-mail of the user sending the request.</param>
		/// <param name="@phonenumber">The phone number of the user sending the request.</param>
		/// <param name="@jobtitle">The job title of the user sending the request.</param>
		/// <param name="@institution">The institution of the user sending the request.</param>
		/// <param name="@comments">Comments entered by the user sending the request.</param>


		public static ActionResult Renew(string @email, string @phonenumber, string @jobtitle, string @institution, string @comments
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "license.renew", new {@email, @phonenumber, @jobtitle, @institution, @comments
});
		}

		

	}
}


