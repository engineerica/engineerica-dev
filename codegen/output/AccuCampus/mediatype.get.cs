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
		/// View a media type.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the media type to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "mediatype.get", new {@id
});
		}

		

	}
}


