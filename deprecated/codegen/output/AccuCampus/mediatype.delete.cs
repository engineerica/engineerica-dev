using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Mediatypes.
	/// </summary>
	public static partial class Mediatype
	{
		
		/// <summary>
		/// Delete a media type.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the media type to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "mediatype.delete", new {@id
});
		}

		

	}
}


