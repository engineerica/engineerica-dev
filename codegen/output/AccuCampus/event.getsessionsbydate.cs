using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Events.
	/// </summary>
	public static partial class Event
	{
		
		/// <summary>
		/// View events by date.  This action requires authentication.
		/// </summary>


		public static ActionResult Getsessionsbydate(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "event.getsessionsbydate", new {
});
		}

		
		/// <summary>
		/// View events by date
		/// </summary>
		/// <param name="@location">The location to filter the events.</param>
		/// <param name="@date">The date to filter the events. Today will be used if this parameter is omitted.</param>
		/// <param name="@type">Type of event to list.</param>


		public static ActionResult Getsessionsbydate(Guid @location, DateTime @date, string @type
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "event.getsessionsbydate", new {@location, @date, @type
});
		}

		

	}
}


