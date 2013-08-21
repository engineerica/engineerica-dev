using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public partial class Swipe : ActionSet
	{
		
		/// <summary>
		/// Get swipe.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the swipe to get.</param>


		public ActionResult Get(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "swipe.get", new {_id
});
		}

		

	}
}


