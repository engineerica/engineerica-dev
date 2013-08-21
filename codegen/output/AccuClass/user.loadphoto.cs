using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public partial class User : ActionSet
	{
		
		/// <summary>
		/// Uploads a photo for a specific user..  This action requires authentication.
		/// </summary>
		/// <param name="_upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>


		public ActionResult Loadphoto(string _upload
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "user.loadphoto", new {_upload
});
		}

		
		/// <summary>
		/// Uploads a photo for a specific user.
		/// </summary>
		/// <param name="_upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="_filename">The local name of the uploaded file. For later reference.</param>
		/// <param name="_userid">The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'.</param>
		/// <param name="_automatch">Set this to true to find the specific user based on the file name. </param>


		public ActionResult Loadphoto(string _upload, string _filename, Guid _userid, bool _automatch
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "user.loadphoto", new {_upload, _filename, _userid, _automatch
});
		}

		

	}
}


