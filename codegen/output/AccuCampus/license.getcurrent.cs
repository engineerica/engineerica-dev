using System;

namespace EngineericaApi.AccuCampus
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "license.getcurrent", new {
});
		}

		

	}
}


