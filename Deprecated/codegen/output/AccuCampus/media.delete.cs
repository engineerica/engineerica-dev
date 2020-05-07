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
		/// Delete a media item.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the media item to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "media.delete", new {@id
});
		}

		

	}
}


