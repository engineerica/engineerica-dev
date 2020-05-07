using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Mys.
	/// </summary>
	public static partial class My
	{
		
		/// <summary>
		/// Gets the current time zone's iana name.  This action requires authentication.
		/// </summary>


		public static ActionResult Ianatimezone(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "my.ianatimezone", new {
});
		}

		

	}
}


