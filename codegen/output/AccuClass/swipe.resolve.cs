using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public partial class Swipe : ActionSet
	{
		
		/// <summary>
		/// Resolves a swipe and creates the attendance log.  This action requires authentication.
		/// </summary>
		/// <param name="_id">The id of the swipe to resolve.</param>


		public ActionResult Resolve(Guid _id
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "swipe.resolve", new {_id
});
		}

		
		/// <summary>
		/// Resolves a swipe and creates the attendance log
		/// </summary>
		/// <param name="_id">The id of the swipe to resolve.</param>
		/// <param name="_session">The id of the session whose swipe has to be saved.</param>
		/// <param name="_user">The id of the user who signed-in.</param>


		public ActionResult Resolve(Guid _id, Guid _session, Guid _user
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "swipe.resolve", new {_id, _session, _user
});
		}

		

	}
}


