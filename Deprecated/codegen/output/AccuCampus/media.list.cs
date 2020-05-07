using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Medias.
	/// </summary>
	public static partial class Media
	{
		
		/// <summary>
		/// View all the media items.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "media.list", new {@from, @count
});
		}

		
		/// <summary>
		/// View all the media items
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@status">Used to filter the media items by their checkout status (0 = CheckedIn, 1 = CheckedOut, Unspecified = All).</param>
		/// <param name="@user">Used to filter the media items that are checked-out by a specific user.</param>


		public static ActionResult List(int @from, int @count, MediaStatus @status, Guid @user
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "media.list", new {@from, @count, @status, @user
});
		}

		

	}
}


