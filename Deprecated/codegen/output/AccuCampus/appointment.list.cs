using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Appointments.
	/// </summary>
	public static partial class Appointment
	{
		
		/// <summary>
		/// View all the appointments.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult List(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.list", new {@from, @count
});
		}

		
		/// <summary>
		/// View all the appointments
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@startdate">The start date of the period to filter the appointments.</param>
		/// <param name="@enddate">The end date of the period to filter the appointments.</param>


		public static ActionResult List(int @from, int @count, DateTime @startdate, DateTime @enddate
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "appointment.list", new {@from, @count, @startdate, @enddate
});
		}

		

	}
}


