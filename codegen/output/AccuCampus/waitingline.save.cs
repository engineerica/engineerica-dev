using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Waitinglines.
	/// </summary>
	public static partial class Waitingline
	{
		
		/// <summary>
		/// Save a waiting line.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the waiting line.</param>
		/// <param name="@location">The id of the location of the waiting line.</param>


		public static ActionResult Save(string @name, Guid @location
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "waitingline.save", new {@name, @location
});
		}

		
		/// <summary>
		/// Save a waiting line
		/// </summary>
		/// <param name="@name">The name of the waiting line.</param>
		/// <param name="@location">The id of the location of the waiting line.</param>
		/// <param name="@id">The id of the waiting line save (leave empty to create a new one).</param>
		/// <param name="@description">The description of the waiting line.</param>
		/// <param name="@service">Specifies the id of the service which persons that are waiting in this line have selected.</param>
		/// <param name="@event">Specifies the id of the event which persons that are waiting in this line have selected.</param>
		/// <param name="@staff">Specifies the id of the staff member which persons that are waiting in this line have selected.</param>


		public static ActionResult Save(string @name, Guid @location, Guid @id, string @description, Guid @service, Guid @event, Guid @staff
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "waitingline.save", new {@name, @location, @id, @description, @service, @event, @staff
});
		}

		

	}
}


