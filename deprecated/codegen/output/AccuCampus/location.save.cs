using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
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


		public static ActionResult Save(string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "location.save", new {@name
});
		}

		
		/// <summary>
		/// Saves location
		/// </summary>
		/// <param name="@name">The name of the location.</param>
		/// <param name="@id">The id of the location save (leave empty to create a new one).</param>
		/// <param name="@categoryid">The id of location's LocationCategory.</param>
		/// <param name="@categoryname">The name of the location's LocationCategory.</param>
		/// <param name="@streetaddress">The street address of the location.</param>
		/// <param name="@latitude">The latitude of the location.</param>
		/// <param name="@longitude">The longitude of the location.</param>
		/// <param name="@websiteurl">The web site url of the location.</param>
		/// <param name="@email">The e-mail address of the location.</param>


		public static ActionResult Save(string @name, Guid @id, Guid @categoryid, string @categoryname, string @streetaddress, decimal @latitude, decimal @longitude, string @websiteurl, string @email
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "location.save", new {@name, @id, @categoryid, @categoryname, @streetaddress, @latitude, @longitude, @websiteurl, @email
});
		}

		

	}
}


