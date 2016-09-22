using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Sessionswipes.
	/// </summary>
	public static partial class Sessionswipe
	{
		
		/// <summary>
		/// Gets a session swipe.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the swipe to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "sessionswipe.get", new {@id
});
		}

		

	}
}


