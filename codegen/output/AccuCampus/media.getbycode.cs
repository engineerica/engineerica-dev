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
		/// Search media item by code.  This action requires authentication.
		/// </summary>
		/// <param name="@code">The code of the media item to get.</param>


		public static ActionResult Getbycode(string @code
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "media.getbycode", new {@code
});
		}

		
		/// <summary>
		/// Search media item by code
		/// </summary>
		/// <param name="@code">The code of the media item to get.</param>
		/// <param name="@location">The location where to look for the media item.</param>


		public static ActionResult Getbycode(string @code, Guid @location
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "media.getbycode", new {@code, @location
});
		}

		

	}
}


