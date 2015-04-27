using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Locations.
	/// </summary>
	public static partial class Location
	{
		
		/// <summary>
		/// Saves location.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the location.</param>
		/// <param name="@mapinfo">The map information of the location.</param>


		public static ActionResult Save(string @name, string @mapinfo
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "location.save", new {@name, @mapinfo
});
		}

		
		/// <summary>
		/// Saves location
		/// </summary>
		/// <param name="@name">The name of the location.</param>
		/// <param name="@mapinfo">The map information of the location.</param>
		/// <param name="@id">The id of the location save (leave empty to create a new one).</param>


		public static ActionResult Save(string @name, string @mapinfo, Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "location.save", new {@name, @mapinfo, @id
});
		}

		

	}
}


