using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public static partial class Swipe
	{
		
		/// <summary>
		/// Resolves a swipe and creates the attendance log.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the swipe to resolve.</param>


		public static ActionResult Resolve(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "swipe.resolve", new {@id
});
		}

		
		/// <summary>
		/// Resolves a swipe and creates the attendance log
		/// </summary>
		/// <param name="@id">The id of the swipe to resolve.</param>
		/// <param name="@session">The id of the session whose swipe has to be saved.</param>
		/// <param name="@user">The id of the user who signed-in.</param>


		public static ActionResult Resolve(Guid @id, Guid @session, Guid @user
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "swipe.resolve", new {@id, @session, @user
});
		}

		

	}
}


