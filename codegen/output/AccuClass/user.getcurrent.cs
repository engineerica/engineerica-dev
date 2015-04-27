using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Users.
	/// </summary>
	public static partial class User
	{
		
		/// <summary>
		/// Gets current user.  This action requires authentication.
		/// </summary>


		public static ActionResult Getcurrent(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "user.getcurrent", new {
});
		}

		

	}
}


