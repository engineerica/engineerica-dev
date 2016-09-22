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
		/// Deletes a service.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the service to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "service.delete", new {@id
});
		}

		

	}
}


