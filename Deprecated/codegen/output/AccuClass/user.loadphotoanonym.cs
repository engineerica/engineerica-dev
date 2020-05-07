using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Uploads a photo for a specific user from a sign-in station.
		/// </summary>
		/// <param name="@station">The id of the sign-in station.</param>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>


		public static ActionResult Loadphotoanonym(Guid @station, string @upload
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, false, "user.loadphotoanonym", new {@station, @upload
});
		}

		
		/// <summary>
		/// Uploads a photo for a specific user from a sign-in station.
		/// </summary>
		/// <param name="@station">The id of the sign-in station.</param>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@filename">The local name of the uploaded file. For later reference.</param>


		public static ActionResult Loadphotoanonym(Guid @station, string @upload, string @filename
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, false, "user.loadphotoanonym", new {@station, @upload, @filename
});
		}

		

	}
}


