using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public partial class User : ActionSet
	{
		
		/// <summary>
		/// Deletes an user.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the user to delete.</param>


		public ActionResult Delete(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "user.delete", new {_id
});
		}

		

	}
}


