using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public partial class User : ActionSet
	{
		
		/// <summary>
		/// Saves user.  This action requires authentication.
		/// </summary>
		/// <param name="_firstname">The first name of the user.</param>
		/// <param name="_lastname">The last name of the user.</param>
		/// <param name="_roles">Comma separated list of roles of the user.</param>


		public ActionResult Save(string _firstname, string _lastname, string _roles
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "user.save", new {_firstname, _lastname, _roles
});
		}

		
		/// <summary>
		/// Saves user
		/// </summary>
		/// <param name="_firstname">The first name of the user.</param>
		/// <param name="_lastname">The last name of the user.</param>
		/// <param name="_roles">Comma separated list of roles of the user.</param>
		/// <param name="_id">The id of the user to save (leave empty to create a new one).</param>
		/// <param name="_customid">The ID of the user, unique but can be  anything the user wants.</param>
		/// <param name="_middlename">The middle name of the user.</param>
		/// <param name="_email">The email of the user.</param>
		/// <param name="_card">The card number (can be text) of the user.</param>
		/// <param name="_password">The new password of the user.</param>
		/// <param name="_photoid">The ID of a photo uploaded using user.loadphoto.</param>


		public ActionResult Save(string _firstname, string _lastname, string _roles, Guid _id, string _customid, string _middlename, string _email, string _card, string _password, Guid _photoid
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "user.save", new {_firstname, _lastname, _roles, _id, _customid, _middlename, _email, _card, _password, _photoid
});
		}

		

	}
}


