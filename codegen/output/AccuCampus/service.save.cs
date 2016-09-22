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
		/// Saves a service.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the service.</param>


		public static ActionResult Save(string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "service.save", new {@name
});
		}

		
		/// <summary>
		/// Saves a service
		/// </summary>
		/// <param name="@name">The name of the service.</param>
		/// <param name="@id">The id of the service save (leave empty to create a new one).</param>
		/// <param name="@type">The type of the service.</param>
		/// <param name="@globallyavailable">Whether the service is available for all the services.</param>
		/// <param name="@description">The description of the service.</param>


		public static ActionResult Save(string @name, Guid @id, string @type, bool @globallyavailable, string @description
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "service.save", new {@name, @id, @type, @globallyavailable, @description
});
		}

		

	}
}


