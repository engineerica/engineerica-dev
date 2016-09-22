using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "my.ianatimezone", new {
});
		}

		

	}
}


