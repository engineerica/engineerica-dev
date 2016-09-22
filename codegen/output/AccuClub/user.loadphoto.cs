using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Uploads a photo for a specific user..  This action requires authentication.
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>


		public static ActionResult Loadphoto(string @upload
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "user.loadphoto", new {@upload
});
		}

		
		/// <summary>
		/// Uploads a photo for a specific user.
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@filename">The local name of the uploaded file. For later reference.</param>
		/// <param name="@userid">The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'.</param>
		/// <param name="@automatch">Set this to true to find the specific user based on the file name. </param>


		public static ActionResult Loadphoto(string @upload, string @filename, Guid @userid, bool @automatch
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "user.loadphoto", new {@upload, @filename, @userid, @automatch
});
		}

		

	}
}


