using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Medias.
	/// </summary>
	public static partial class Media
	{
		
		/// <summary>
		/// View a media item.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the media item to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "media.get", new {@id
});
		}

		

	}
}


