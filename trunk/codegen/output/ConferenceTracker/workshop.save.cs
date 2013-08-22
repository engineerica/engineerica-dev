using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Workshops.
	/// </summary>
	public static partial class Workshop
	{
		
		/// <summary>
		/// Saves a workshop.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the workshop.</param>
		/// <param name="@starttime">The start date and time of the workshop, in ISO format.</param>
		/// <param name="@endtime">The end time of the workshop, in ISO format.</param>
		/// <param name="@room">The id of the room where it takes place.</param>
		/// <param name="@conference">The id of the conference where the workshop takes place.</param>


		public static ActionResult Save(string @name, DateTime @starttime, DateTime @endtime, Guid @room, Guid @conference
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshop.save", new {@name, @starttime, @endtime, @room, @conference
});
		}

		
		/// <summary>
		/// Saves a workshop
		/// </summary>
		/// <param name="@name">The name of the workshop.</param>
		/// <param name="@starttime">The start date and time of the workshop, in ISO format.</param>
		/// <param name="@endtime">The end time of the workshop, in ISO format.</param>
		/// <param name="@room">The id of the room where it takes place.</param>
		/// <param name="@conference">The id of the conference where the workshop takes place.</param>
		/// <param name="@id">The id of the workshop to save (leave empty to create a new one).</param>
		/// <param name="@credits">The credits of the workshop.</param>
		/// <param name="@speakers">The speakers of the workshop.</param>


		public static ActionResult Save(string @name, DateTime @starttime, DateTime @endtime, Guid @room, Guid @conference, Guid @id, decimal @credits, string @speakers
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "workshop.save", new {@name, @starttime, @endtime, @room, @conference, @id, @credits, @speakers
});
		}

		

	}
}


