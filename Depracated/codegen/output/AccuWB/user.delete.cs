using System;

namespace EngineericaApi.AccuWB
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Deletes an user.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the user to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuWB, true, "user.delete", new {@id
});
		}

		

	}
}


