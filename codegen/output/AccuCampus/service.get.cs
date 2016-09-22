using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Services.
	/// </summary>
	public static partial class Service
	{
		
		/// <summary>
		/// Get service.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the service to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "service.get", new {@id
});
		}

		

	}
}


