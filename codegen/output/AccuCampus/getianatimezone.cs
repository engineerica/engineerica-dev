using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Getianatimezones.
	/// </summary>
	public static partial class Getianatimezone
	{
		
		/// <summary>
		/// Gets the current time zone's iana name.  This action requires authentication.
		/// </summary>


		public static ActionResult Execute(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "getianatimezone", new {
});
		}

		

	}
}


