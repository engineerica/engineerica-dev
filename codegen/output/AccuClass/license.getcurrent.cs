using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Licenses.
	/// </summary>
	public static partial class License
	{
		
		/// <summary>
		/// Gets the current license information.  This action requires authentication.
		/// </summary>


		public static ActionResult Getcurrent(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "license.getcurrent", new {
});
		}

		
		/// <summary>
		/// Gets the current license information
		/// </summary>
		/// <param name="@station">The id of the sign-in station whose account's license has to be retrieved.</param>


		public static ActionResult Getcurrent(string @station
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "license.getcurrent", new {@station
});
		}

		

	}
}


