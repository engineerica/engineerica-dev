using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Swipes.
	/// </summary>
	public static partial class Swipe
	{
		
		/// <summary>
		/// Get swipe.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the swipe to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "swipe.get", new {@id
});
		}

		

	}
}


