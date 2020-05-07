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
		/// Gets the list of user profiles.  This action requires authentication.
		/// </summary>


		public static ActionResult List(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "userprofile.list", new {
});
		}

		
		/// <summary>
		/// Gets the list of user profiles
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "userprofile.list", new {@from, @count
});
		}

		

	}
}


