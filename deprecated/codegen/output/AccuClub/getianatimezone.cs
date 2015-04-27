using System;

namespace EngineericaApi.AccuClub
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "getianatimezone", new {
});
		}

		

	}
}


