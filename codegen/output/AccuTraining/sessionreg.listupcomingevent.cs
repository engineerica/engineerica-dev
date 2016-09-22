using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Sessionregs.
	/// </summary>
	public static partial class Sessionreg
	{
		
		/// <summary>
		/// View all the upcoming sessions of a particular event.  This action requires authentication.
		/// </summary>
		/// <param name="@date">Start date to filter the returned sessions.</param>
		/// <param name="@event">The id of the event whose sessions will be returned</param>


		public static ActionResult Listupcomingevent(DateTime @date, Guid @event
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "sessionreg.listupcomingevent", new {@date, @event
});
		}

		

	}
}


