using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Userprofiles.
	/// </summary>
	public static partial class Userprofile
	{
		
		/// <summary>
		/// Gets the statistics of a user group.  This action requires authentication.
		/// </summary>


		public static ActionResult Preparestats(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "userprofile.preparestats", new {
});
		}

		
		/// <summary>
		/// Gets the statistics of a user group
		/// </summary>
		/// <param name="@params">The ID of the group, specified as 'group=...'</param>


		public static ActionResult Preparestats(string @params
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "userprofile.preparestats", new {@params
});
		}

		

	}
}


