using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public partial class Swipe : ActionSet
	{
		
		/// <summary>
		/// Deletes a swipe.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the swipe to delete.</param>


		public ActionResult Delete(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "swipe.delete", new {_id
});
		}

		

	}
}


