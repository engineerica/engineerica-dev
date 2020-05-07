using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Actionlogs.
	/// </summary>
	public static partial class Actionlog
	{
		
		/// <summary>
		/// View all the users action logs.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "actionlog.list", new {@from, @count
});
		}

		
		/// <summary>
		/// View all the users action logs
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@user">The id of the user whose action logs have to be returned.</param>
		/// <param name="@startdate">The start date of the period to filter the logs.</param>
		/// <param name="@enddate">The end date of the period to filter the logs.</param>
		/// <param name="@resource">The resource to filter the action logs.</param>
		/// <param name="@actionfilter">The action to filter the action logs.</param>
		/// <param name="@argument">The id of the entity that was the argument of the executed action.</param>


		public static ActionResult List(int @from, int @count, Guid? @user, DateTime @startdate, DateTime @enddate, string @resource, string @actionfilter, string @argument
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "actionlog.list", new {@from, @count, @user, @startdate, @enddate, @resource, @actionfilter, @argument
});
		}

		

	}
}


